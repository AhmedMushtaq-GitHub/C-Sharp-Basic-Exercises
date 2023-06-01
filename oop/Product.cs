/*using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    *//*//Making a class
    public class product
    {
        //making variables/fields
        public string name;
        public float price;
        //making a flot method for return price value
        public float GetPrice()
        { return price; }
        //when wo do  not want to return value we use void method
        public void SetPrice(float value)
        {
            if (value < 0)
            { 
                Console.WriteLine("Error you have entered "+ value);
            return;
            }
            else 
            {
                price = value;
            }
        }
    }
*//*
    public class Student
    {
        string name;
        private int id;
        public int rollNumber;
        public int gender;



        public int Stdid
        {
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("non negative");
                }
                else 
                {
                    this.id=value;
                }
            }
            get
            {
                return this.id;
            }
        }
    }


    public class person
    {
        public static void Main(string[] args)
        {
            Student s=new Student();
            s.Stdid = 1;
            Console.WriteLine(s.Stdid);


        }



    }






}




*/
using System;
namespace oop
{
    public class Student
    {
        private string name;
        private string FatherName;
        private int age;

        public string stuname
    {
        set
            {
                this.name = value;
                this.FatherName = value;
            }
            
            get
            {
                return this.name;
                return this.FatherName;
            }
    }
        public int stuage
        {
            set { this.age = value; }
            get { return this.age; }
        }
     public class OutPut
        {
            public static void Main()
            {
                Student stu = new Student();
                stu.stuname = "AHmed";
                Console.WriteLine(stu.stuname);
                stu.FatherName = "Mushtaq";
                Console.WriteLine(stu.FatherName);

            
            stu.age = 25;
                Console.WriteLine(stu.age);
            }

        }

}
    


















}