using System;

//<Summary>Sample/<Summary>
namespace Sample_Circular_Queues
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {

            /* Menginisialisasi nilai variabels REAR dan FRONT ke -1 untuk menunjukkan bahwa antrian awalnya kosong. */
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {

            /* Pernyataan berikut memeriksa apakah antrian kosong. Jika antrian kosong, maka nilai variabel REAR dan FRONT diatur ke 0. */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {

                /* Jika REAR berada di posisi terakhir array, maka nilai REAR diatur ke 0 yang sesuai dengan posisi pertama array. */
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /* Jika REAR tidak pada posisi terakhir, maka nilainya cenderung satu.  */
                    REAR = REAR + 1;
            }

            /* Setelah posisi REAR ditentukan, elemen ditambahkan di tempat yang tepat. */
            queue_array[REAR] = element;
        }
        public void remove()
        {

            /* Memeriksa apakah antrean kosong. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[FRONT] + "\n");

            /* Memeriksa apakah antrean memiliki satu elemen. */
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {

                /* Jika elemen yang akan dihapus berada di posisi terakhir array, maka nilai FRONT diatur ke 0 yaitu ke elemen pertama array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else

                    /* FRONT bertambah satu jika bukan elemen pertama dari array. */
                    FRONT = FRONT + 1;
            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;

            /* Memeriksa apakah antrean kosong. */
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElement is the queue are.............\n");
            if (FRONT_position <= REAR_position)
            {

                /* Melintasi antrean hingga elemen terakhir yang ada dalam array. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {

                /* Lintasi antrean hingga posisi terakhir array. */
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }

                /* Mengatur posisi FRONT ke elemen pertama array. */
                FRONT_position = 0;

                /* Lintasi array hingga elemen terakhir yang ada dalam antrean. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + " ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void main(string[] args)
        {
            Queues q = new Queues();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement Insert Operation");
                    Console.WriteLine("2. Implement Delete Operation");
                    Console.WriteLine("3. Display Values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter Your Choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option!!");
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Check for the values  Entered.");
                }
            }
        }
    }
}