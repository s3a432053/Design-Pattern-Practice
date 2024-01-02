namespace Test
{
    public class ForTest
    {
        private int count = 0;

        // 找出相差最小的所有元素組合 1 - 效能差的版本
        public void FindClosestNumbers(List<int> numbers)
        {
            List<Tuple<int, int>> result = new();
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = numbers.Count - 1; j > i; j--)
                {

                    if (Math.Abs(numbers[i] - numbers[j]) == 0)
                    {
                        continue;
                    }

                    if (Math.Abs(numbers[i] - numbers[j]) < min)
                    {
                        result.Clear();
                        if (numbers[i] > numbers[j])
                        {
                            if (!result.Contains(Tuple.Create(numbers[j], numbers[i])))
                            {
                                result.Add(Tuple.Create(numbers[j], numbers[i]));
                            }
                        }
                        else
                        {
                            if (!result.Contains(Tuple.Create(numbers[i], numbers[j])))
                            {
                                result.Add(Tuple.Create(numbers[i], numbers[j]));
                            }
                        }
                        min = Math.Abs(numbers[i] - numbers[j]);
                    }
                    else if (Math.Abs(numbers[i] - numbers[j]) == min)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            if (!result.Contains(Tuple.Create(numbers[j], numbers[i])))
                            {
                                result.Add(Tuple.Create(numbers[j], numbers[i]));
                            }
                        }
                        else
                        {
                            if (!result.Contains(Tuple.Create(numbers[i], numbers[j])))
                            {
                                result.Add(Tuple.Create(numbers[i], numbers[j]));
                            }
                        }
                    }
                }
            }

            result = result.OrderBy(tuple => tuple.Item1).ThenBy(tuple => tuple.Item2).ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
            }
        }

        // 找出相差最小的所有元素組合 2 - 效能 OK 的版本
        public void FindClosestNumbers2(List<int> numbers)
        {
            // 先將陣列做排序
            numbers.Sort();

            List<Tuple<int, int>> result = new();

            int pointer1 = 0;
            int pointer2 = 1;

            // 目前最小值
            int min = int.MaxValue;

            // 當 pointer2 走到底代表沒組合可以檢查了
            while (pointer2 < numbers.Count)
            {
                // 檢查兩個 pointer 的 value 相減是否為目前所有相減組合中最小
                if (numbers[pointer2] - numbers[pointer1] < min)
                {
                    // 清空
                    result.Clear();
                    // 加入組合
                    result.Add(Tuple.Create(numbers[pointer1], numbers[pointer2]));
                    // 設定新的最小差
                    min = numbers[pointer2] - numbers[pointer1];
                }
                else if (numbers[pointer2] - numbers[pointer1] == min)
                {
                    // 加入新的最小差組合
                    result.Add(Tuple.Create(numbers[pointer1], numbers[pointer2]));
                }

                pointer1++;
                pointer2++;
            }

            // 印出結果
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
            }
        }

        // 鈦坦 考試第三題 摧毀星球
        public int DestroyPlane(List<int> planets)
        {
            // 用來放應該被移除的星球列表
            int smallest = int.MaxValue;

            // 一一檢查每個元素被拿掉後 剩下元素的 奇數index總和 是否 == 偶數index總和
            for (int i = 0; i < planets.Count; i++)
            {
                // 將陣列複製一份起來做測試
                List<int> tempList = new List<int>(planets);

                // 嘗試將 i index 的元素拿掉
                tempList.RemoveAt(i);

                // 檢查 奇數 index 的合 是否 == 偶數 index 的合
                if (SumAtIndex(tempList, true) == SumAtIndex(tempList, false))
                {
                    // 如果移除當前元素後满足條件，返回被移除的元素
                    smallest = planets[i];
                }
            }

            // 如果没有找到符合条件的元素，返回 -1
            if (smallest == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return planets.Find(x => x == smallest);
            }
        }

        /// <summary>
        /// 加總 奇數 index 的合 or 偶數 index 的合
        /// </summary>
        /// <param name="list"></param>
        /// <param name="isOddIndex">是否為奇數</param>
        /// <returns></returns>
        private int SumAtIndex(List<int> list, bool isOddIndex)
        {
            int sum = 0;

            for (int i = isOddIndex ? 1 : 0; i < list.Count; i += 2)
            {
                count++;
                sum += list[i];
            }

            return sum;
        }
    }
}
