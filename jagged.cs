using System;

namespace JaggedArray
{
    public static  class jagged{ 
         static jagged(){

         }

        public  static void JaggedArrayInt(){ 
            int [][] jgArray =new int [4][];
            jgArray[0]= new int[3] {2,5,6};
            jgArray[1]= new int[5]{3,5,9,12,15};
            jgArray[2]= new int[1]{10};
            jgArray[3]= new int[4]{50,150,250,500};

            for(int i=0;i<jgArray.Length;i++){
               Console.Write($"Element {i+1} : ");
               for(int j=0;j<jgArray[i].Length;j++){
                    System.Console.Write(jgArray[i][j] + "\t");  
               }
              Console.WriteLine();
            }

            Console.ReadLine();
        }

        public static void JaggedArrayString(){
            string [][] members=new string[][]{
             new string[]{"Rocky", "Sam", "Alex"},  
             new string[]{"Peter", "Sonia", "Prety", "Ronnie", "Dino"},  
             new string[]{"Yomi", "John", "Sandra", "Alex", "Tim", "Shaun"},  
             new string[]{"Teena", "Mathew", "Arnold", "Stallone", "Goddy", "Samson", "Linda"}  
            };
             string [][] members2={
             new string[]{"Rocky", "Sam", "Alex"},  
             new string[]{"Peter", "Sonia", "Prety", "Ronnie", "Dino"},  
             new string[]{"Yomi", "John", "Sandra", "Alex", "Tim", "Shaun"},  
             new string[]{"Teena", "Mathew", "Arnold", "Stallone", "Goddy", "Samson", "Linda"}  
            };
          
           for(int i=0;i<members2.Length;i++){
               Console.Write($"Element {i+1} :");
               for(int j=0;j<members2[i].Length;j++){
                   Console.Write(members2[i][j]+"\t");
               }
               Console.WriteLine();
           }
           Console.ReadLine();

        }


        public static void JaggedArrayMix(){
            int[][,] jgMix=new int [3][,]{
                new int [,]{{15,20},{18,69}},
                new int [,]{{1,3},{4,5},{98,78},{85,98},{55,78}},
                new int [,]{{1,2}}

            };
            Console.WriteLine(jgMix[1][2,1]);
            
             for(int i=0;i<jgMix.Length;i++){

                var subArray = jgMix[i];
                var ss= subArray[0,1];
                Console.WriteLine(ss);

                var row= subArray.GetLength(0);
                var col = subArray.GetLength(1);
                for(int d =0; d<row;d++){
                    for(int e =0;e<col;e++){
                    var g= subArray[d,e];
                    Console.Write(g +"\t");
                    }                
                }
                Console.WriteLine();
             }

        }

    }
}