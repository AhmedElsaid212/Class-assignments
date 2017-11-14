
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDegrees
{
    class Program
    {
        static string[] names=new string[n];
        static int[] degs= new int[n];
        static int n;
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number of students\n");
            n= int.Parse(Console.ReadLine());
            
            
            
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Enter student "+ (0) +" name: \n");
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter his/her degree: \n");
                degs[i] = int.Parse(Console.ReadLine());
                
            }
            
            Console.WriteLine("Choose an option from the following minue\n");
            Console.WriteLine("=========================================\n");
            Console.WriteLine("[1] Search for a student degree\n");
            Console.WriteLine("[2] Get top student name and degree\n");
            Console.WriteLine("[3] Change a student's name\n");
            
            int c = int.Parse(Console.ReadLine());
            if(c==1){
                getDegree();
            }else if(c==2){
                getTop();
            }else if (c==3){
                changeName();
            }else{
                Console.WriteLine("Wrong choice");
            }
          
        }
        
        public static void getDegree(){
            Console.WriteLine("Enter student name\n");
                    string name=Console.ReadLine();
                    if(Array.IndexOf(names,name)!=-1){
                        int x = Array.IndexOf(names,name);
                        Console.WriteLine("student "+name+" score is : "+degs[x]);
                    }else{
                        Console.WriteLine("student not found\n");
                    }
           
        }
        
        public static void getTop()
        {
            Array.Sort(degs,names);
            Console.WriteLine("Top student name is "+names[n+1]+" and his/her score is "+degs[n+1]);
        }
        
        
        public static void changeName()
        {
            Console.WriteLine("Enter student's old name : \n");
            string nameOld =Console.ReadLine();
            if(Array.IndexOf(names,nameOld)!=-1){
                Console.WriteLine("Enter new name : \n");
                string nameNew= Console.ReadLine();
                int x=Array.IndexOf(names, nameOld);
                names[x]=nameNew;
                Console.WriteLine("Name successfully changed from "+nameOld+ " to "+ nameNew);
            }else{
                Console.WriteLine("student not found\n");
            }
                    
        }
        
    }
}
