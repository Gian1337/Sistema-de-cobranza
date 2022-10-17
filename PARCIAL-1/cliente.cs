using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_1
{
    class cliente
    {
        public string Nombre { get; set; }
        public cliente Siguiente { get; set; }
        public float Importe { get; set; }
        
    }

    //TEORIA



    // 1) Una FUNCION RECURSIVA son aquellas funciones que se llaman a sí mismas. Toda recursividad debe tener una condición de corte.





    /* 2) Existen varios tipos de listas:

        1. LISTAS: a-Enlazadas: Tiene un enlace por nodo. Este enlace apunta al siguiente nodo (o indica que tiene la dirección en memoria del siguiente nodo) en la lista, o al valor NULL o a la lista vacía, si es el último nodo.

              b-Doblemente Enlazadas: Cada nodo tiene dos enlaces: uno apunta al nodo anterior, o apunta al valor NULL si es el primer nodo; y otro que apunta al nodo siguiente, o apunta al valor NULL si es el último nodo.

              c-Circulares: El primer y el último nodo están unidos juntos.

        2.PILAS

       

        3.COLAS



     */

    /*

     3)

      PILAS: Es una lista particular en la cual los elementos almacenados en la misma se agregan y se sacan del mismo lugar , llamado cima o tope de la pila.

          El tope es el unico lugar a partir del cual se pueden acceder a los elementos de la estructura.

          Tipo de estructura LIFO (el ultimo elemento en ser insertado en la pila es el primero en salir.



          Operaciones: -PUSH -POP -TOP/PEEK -LLENA/VACIA





      COLAS: Es una estructura de datos en la cual los primeros almacenados en la misma se agregan al final y se sacan del principio de la cola.

          Esta caracteristica hace que el primer elemento insertado en la cola es el primero en salir, como en cualquier cola de la realidad.

          Tipo de estructura FIFO (First In First Out).

           

          Operaciones: -ENQUEUE -DEQUEUE -PEEK -LLENA/VACIA

     */



    // 4) TDA significa 'Tipo de Dato Abstracto'. Es un conjunto de datos u objetos al cual se le asocian operaciones.
}
