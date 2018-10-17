using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2_Jaramillo_Regino_Hector_Armando
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodos que comparten las pilas y las colas
            //GetType           //AsParallel        //CopyTo
            //ToString          //AsQueryable       //Equals
            //Contains          //Cast              //GetHashCode
            //ToArray           //Clear             //Peek  
            //GetEnumerator     //Clone             //Count
            //Metodos de Stacks(Pilas)
            //Push
            //Pop
            //Metodos de Queue(Colas)
            //DeQueue
            //EnQueue
            //TrimToSize
            Stack pila = new Stack();
            pila.Push(34.5);
            pila.Push("Francisco");
            pila.Push('A');
            pila.Push(123);
            Console.WriteLine("---------GetEnumerator------------");
            var enumerador = pila.GetEnumerator();//GetEnumerator permite usar enumeradores para recorrer la pila.
            while (enumerador.MoveNext())//desplaza el enumerador a la siguiente posicion de la coleccion
            {
                var item = enumerador.Current;
                Console.WriteLine(item);
            }
            Console.WriteLine("-------- La pila Normal --------");// Muestro la pila.
            foreach (var valor in pila)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("---------Cambio a ToArray------------");
            Stack pila2 = new Stack(pila.ToArray());//Copia la pila a una matriz nueva
            foreach (var valor in pila2)//Impresion del la matriz
            {
                Console.WriteLine(valor);
            }
            // Revisa si la pila contiene la cadena"
            Console.WriteLine("---------- Metodo Contains -------------");
            bool contiene = pila.Contains("Francisco");//variable bool y verificaion si la pila contiene a francisco
            Console.WriteLine(contiene);
            if (contiene == true)//Si contiene es verdadero
            {
                Console.WriteLine("La pila si contiene a Francisco");
            }
            else//Si no
            {
                Console.WriteLine("La pila no contiene a Francisco");
            }
            Console.WriteLine("------------GetType------------");
            Console.WriteLine("El tipo de dato de 123 es: {0}", pila.Pop().GetType());//Nos dice el tipo de la instancia actual
            Console.WriteLine("-----Se utilizo Pop para sacar 123 de la lista---------");
            Console.WriteLine("---------Uso de To String------------");
            Console.WriteLine(pila.Contains(123).ToString());//Convierte el valor de la instancia a Verdadero o Falso 
            Console.ReadKey(true);
            Console.WriteLine("----------------Colas---------------------");
            Queue cola = new Queue();//Inicializacion de cola
            cola.Enqueue("Hola");//Agrega un objeto al final de la cola
            cola.Enqueue(5);
            cola.Enqueue('A');
            cola.Enqueue(16.5);
            cola.Enqueue(3);
            cola.Enqueue("Hello My World");
            cola.TrimToSize();// Restringe la capacidad de la cola al número actual de elementos en la cola,esto reduce el gasto de memoria.
                              //Se puede comprobar en listas con el metodo Capacity pero en Queue no esta implementadp este metodo
            Console.WriteLine("Elementos guardados en la cola={0}:",cola.Count);//Nos dice la cantidad de elementos en la cola          
            Console.WriteLine("-------- La cola Normal --------");// Impresion de la cola.
            foreach (var valor in cola)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("-------- La cola despues de usar Queue --------");// Impresion de la colaluego de eliminar 1 elemento
            cola.Dequeue();//Elimina el primer elemento de la cola
            foreach (var valor in cola)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine("---------Cambio a ToArray------------");
            Queue cola2 = new Queue(cola.ToArray());//Copia la cola a una matriz nueva
            foreach (var valor in cola2)//Impresion del la matriz
            {
                Console.WriteLine(valor);
            }
            // Revisa si la pila contiene la cadena"
            Console.WriteLine("---------- Metodo Contains -------------");
            bool contiene2 = cola.Contains(3);//variable bool y verificaion si la cola contiene a francisco
            Console.WriteLine(contiene2);
            if (contiene2 == true)//Si contiene es verdadero
            {
                Console.WriteLine("La cola si contiene el valor 3");
            }
            else//Si no
            {
                Console.WriteLine("La cola no contiene el numero 3");
            }
            Console.WriteLine("------------GetType------------");
            Console.WriteLine("El tipo de dato en la posicion 0 es de tipo: {0}", cola.Dequeue().GetType());//Nos dice el tipo de la instancia actual
            Console.WriteLine("-----Se utilizo Dequeue para sacar 123 de la lista---------");
            Console.WriteLine("---------Uso de To String------------");
            Console.WriteLine(pila.Contains(3).ToString());//Convierte el valor de la instancia a Verdadero o Falso 
            Console.WriteLine("---------GetEnumerator------------");
            IEnumerator enumerador2 = cola.GetEnumerator();//GetEnumerator permite usar enumeradores para recorrer la pila.
            enumerador2.MoveNext();
            enumerador2.MoveNext();
            Console.WriteLine("\nEl enumerador se movio 2 veces, la el valor en esa posicion es: {0}", enumerador2.Current); //Current para ver el valor en el que se quedo el enumerador
            Console.ReadKey(true);
        }
    }
}

