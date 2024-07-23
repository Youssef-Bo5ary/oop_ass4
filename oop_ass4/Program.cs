namespace oop_ass4
{
    internal class Program
    {
        public static decimal ReadDecimalFromUser(string message)
        {
            decimal number;
            bool validInput = false;

            do
            {
                Console.Write(message);
                string userInput = Console.ReadLine();
                validInput = decimal.TryParse(userInput, out number);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                }
            }
            while (!validInput);

            return number;
        }
        static void Main(string[] args)
        {
            #region Question2
            //Point3D p = new Point3D(10, 10, 10);
            //Console.WriteLine(p.ToString); 
            #endregion

            #region Question3&4
            //decimal dim1 = ReadDecimalFromUser("Enter the first decimal number: ");
            //decimal dim2 = ReadDecimalFromUser("Enter the second decimal number: ");
            //decimal dim3 = ReadDecimalFromUser("Enter the third decimal number: ");
            //Point3D p1 = new Point3D(dim1, dim2, dim3);
            //decimal num1 = ReadDecimalFromUser("Enter the first decimal number: ");
            //decimal num2 = ReadDecimalFromUser("Enter the second decimal number: ");
            //decimal num3 = ReadDecimalFromUser("Enter the third decimal number: ");
            //Point3D p2 = new Point3D(num1, num2, num3);

            //if (p1 == p2)
            //{
            //    Console.WriteLine(true);

            //} 
            #endregion

            #region Define an array of points and sort this array based on X & Y coordinates.

            Point3D[] points = new Point3D[3];
            points[0]=new Point3D(1,2,3);
            points[1]=new Point3D(10,20,30);
            points[2] = new Point3D(100, 200, 300);
            Array.Sort(points);
            
            
            

                
            
            
            
            

            
            
            
               
            
            
            
            #endregion


        }
    }
}
    

