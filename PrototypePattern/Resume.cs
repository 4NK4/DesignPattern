using System;

namespace PrototypePattern
{
    class Resume : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Company Company { get; private set; }

        public Resume(int age, string name)
        {
            Age = age;
            Name = name;
        }


        public void SetCompany(Company company)
        {
            Company = (Company)company.Clone();
        }



        /// <summary>
        /// 打印个人信息
        /// </summary>
        public void Printf()
        {
            System.Console.WriteLine($"年龄:{Age};姓名:{Name};公司:{Company.Name};公司电话:{Company.Phone}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
