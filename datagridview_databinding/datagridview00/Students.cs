using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datagridview00
{
    class Students : List<Student>
    {
        public void SortByAgeAsc()
        {
            Student stuTmp = new Student();
            for (int i = 0; i < Count; i++)
            {
                for (int j = i; j < Count; j++)
                {
                    if (this[i].Age > this[j].Age)
                    {
                        stuTmp = this[i];
                        this[i] = this[j];
                        this[j] = stuTmp;
                    }
                }
            }
        }
    }
}
