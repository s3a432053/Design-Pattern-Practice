using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> CompareDic = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (CompareDic.ContainsKey(target - nums[i]))
                {
                    return new int[] { CompareDic[target - nums[i]], i };
                }
                else
                {
                    if (!CompareDic.ContainsKey(nums[i]))
                    {
                        CompareDic.Add(nums[i], i);
                    }
                }
            }

            return Array.Empty<int>();
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            var orderNums = nums.OrderBy(x => x).ToArray();

            int start = 0;
            int end = orderNums.Length - 1;

            while (start < end)
            {
                if (orderNums[start] + orderNums[end] > target)
                {
                    end--;
                }
                else if (orderNums[start] + orderNums[end] < target)
                {
                    start++;
                }
                else
                {
                    int startIndex = Array.IndexOf(nums, orderNums[start]);
                    int endIndex = Array.IndexOf(nums, orderNums[end]);
                    if (startIndex != endIndex)
                    {
                        return new int[] { startIndex, endIndex };
                    }
                    else
                    {
                        return new int[] { start, end };
                    }
                }
            }

            return Array.Empty<int>();
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) return "";

            var orderStrs = strs.OrderBy(x => x.Length).ToArray();

            var result = orderStrs[0].ToCharArray();

            for (int i = 1; i < orderStrs.Length; i++)
            {
                int pointer = 0;

                var compareArray = orderStrs[i].ToCharArray();

                List<char> tempResult = new();

                while(pointer < result.Length)
                {
                    if (result[pointer] == compareArray[pointer])
                    {
                        tempResult.Add(compareArray[pointer]);
                        pointer++;
                    }
                    else
                    {
                        break;
                    }
                }

                result = tempResult.ToArray();
            }

            return string.Concat(result);
        }

        public string LongestCommonPrefix2(string[] strs)
        {
            if (strs == null || strs.Length == 0)  // If the input array is null or empty, return an empty string
                return "";

            string prefix = strs[0];  // Initialize prefix with the first string in the array

            for (int i = 1; i < strs.Length; i++)
            {
                // Keep reducing the prefix until it is a prefix of the current string
                while (!strs[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (string.IsNullOrEmpty(prefix))
                        return "";  // If the prefix becomes empty, return an empty string
                }
            }

            return prefix;
        }

        public string LongestCommonPrefix3(string[] strs)
        {
            var minStringlength = strs.OrderBy(x => x.Length).First().Length;

            var result = new List<char>();

            for (int i = 0; i < minStringlength; i++)
            {
                char compareChar = '\0';

                for (int j = 0; j < strs.Length; j++)
                {
                    var charArray = strs[j].ToCharArray();

                    if (compareChar == '\0')
                    {
                        compareChar = charArray[0];
                    }
                    else
                    {
                        if (compareChar != charArray[i])
                        {
                            break;
                        }
                    }
                }
            }

            return string.Concat(result);
        }

        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            char[] leftChars = new char[] { '(', '[', '{' };
            char[] rightChars = new char[] { ')', ']', '}' };

            var array = s.ToCharArray();

            if (array.Length % 2 == 1)
            {
                return false;
            }

            var stack = new Stack<char>();

            for (var i = 0; i < array.Length; i++)
            {
                if (Array.IndexOf(leftChars, array[i]) != -1)
                {
                    stack.Push(array[i]);
                }
                else
                {
                    if (!stack.Any())
                    {
                        return false;
                    }

                    var index = Array.IndexOf(rightChars, array[i]);

                    if (leftChars[index] != stack.Pop())
                    {
                        return false;
                    }
                }
            }

            if (stack.Any())
            {
                return false;
            }

            return true;
        }

        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            int max = 0;
            int start = 0;
            int end = 1;

            while(end < prices.Length)
            {
                if (prices[start] > prices[end])
                {
                    start = end;
                }
                else
                {
                    if (prices[end] - prices[start] > max)
                    {
                        max = prices[end] - prices[start];
                    }
                }

                end++;
            }

            return max;
        }

        public int RomanToInt(string s)
        {
            var array = s.ToCharArray();

            Dictionary<char, int> dic = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int sum = 0;
            int minus = 0;

            for(int i = 0; i < array.Length; i++)
            {
                sum += dic[array[i]];

                if (i == 0)
                {
                    continue;
                }

                if (dic[array[i]] > dic[array[i - 1]])
                {
                    var j = i;
                    while (true)
                    {
                        j--;

                        if (j < 0 || dic[array[j]] >= dic[array[i]])
                        {
                            break;
                        }

                        minus += 2 * dic[array[j]];
                    }
                }
            }

            return sum - minus;
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode listNode = new ListNode();
            bool isCarry = false;

            bool firstTime = true;

            // 傳入值為 null => 直接離開
            if (l1 == null || l2 == null)
            {
                return null;
            }

            int sum = 0;

            while (l1 != null || l2 != null || isCarry)
            {
                // 每個位數的總和
                sum = 0;

                // l1 不為 null => 加入 sum、換下一個位數
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                // l2 不為 null => 加入 sum、換下一個位數
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                // 是否有進位
                if (isCarry)
                {
                    sum += 1;
                }

                // 相加後餘除結果
                var modResult = sum % 10;

                // 檢查是否進位
                isCarry = sum >= 10;

                // 找到 NodeList 的結尾
                var currentNode = listNode;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }

                // 判斷是否為第一個位數 => 第一次迴圈
                if (firstTime)
                {
                    currentNode.val = modResult;
                }
                else
                {
                    currentNode.next = new ListNode(modResult);
                }

                firstTime = false;
            }

            return listNode;
        }

        public static void ListNode(ListNode listNode)
        {
            var currentNode = listNode;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.val);
                currentNode = currentNode.next;
            }
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }

            ListNode? result = new();
            ListNode resultCurrentNode = result;
            ListNode currentNode1 = list1;
            ListNode currentNode2 = list2;
            while(currentNode1 != null && currentNode2 != null)
            {
                if (currentNode1.val <= currentNode2.val)
                {
                    resultCurrentNode.val = currentNode1.val;
                    currentNode1 = currentNode1.next;
                }
                else
                {
                    resultCurrentNode.val = currentNode2.val;
                    currentNode2 = currentNode2.next;
                }

                resultCurrentNode.next = new ListNode();
                resultCurrentNode = resultCurrentNode.next;
            }

            while (currentNode1 != null)
            {
                resultCurrentNode.val = currentNode1.val;
                currentNode1 = currentNode1.next;

                if (currentNode1 != null)
                {
                    resultCurrentNode.next = new ListNode();
                    resultCurrentNode = resultCurrentNode.next;
                }
            }

            while (currentNode2 != null)
            {
                resultCurrentNode.val = currentNode2.val;
                currentNode2 = currentNode2.next;

                if (currentNode2 != null)
                {
                    resultCurrentNode.next = new ListNode();
                    resultCurrentNode = resultCurrentNode.next;
                }
            }

            return result;
        }

        public int RemoveDuplicates(int[] nums)
        {
            List<int> exsist = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!exsist.Contains(nums[i]))
                {
                    exsist.Add(nums[i]);
                }
            }

            nums = exsist.ToArray();

            return exsist.Count;
        }

        public static string number_cardinality(int my_number)
        {
            //Insert your code here 
            var end = my_number % 10;
            if (end == 0)
            {
                return "zero";
            } 
            else if (end == 5)
            {
                return "five";
            }
            else
            {
                var mod = end % 2;
                if (mod == 0)
                {
                    return "even";
                }
                else
                {
                    return "odd";
                }
            }
        }

        public static string outputString(string inputString)
        {
            //Insert your code here
            string[] strArray = inputString.Split(" ");
            string[] resultArray = new string[strArray.Length];
            for(int i = strArray.Length - 1; i >= 0; i--)
            {
                resultArray[strArray.Length - 1 - i] = strArray[i];
            }

            return String.Join(" ", resultArray);
        }

    }
}
