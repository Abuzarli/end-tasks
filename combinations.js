
            let arrnum = [ 7, 0, 3, 4, 2, 5, 9, ];
            let num = 7;
            // console.log(arr(arrnum, num));
            let count = 0;
            for (let i = 0; i < arrnum.Length; i++)
            {
                for (let j = i + 1; j < myarr.Length; j++)
                {
                    if ((arrnunm[i] + arrnum[j]) == num)
                    {
                        count++;
                    }
                }
            }
            return count;
            console.log(count);