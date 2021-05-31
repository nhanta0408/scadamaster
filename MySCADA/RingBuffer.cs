using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class RingBuffer
    {
        public int front, rear;
        public dynamic[] nums;
        public int count { get; private set; }
        public RingBuffer(int initialSize)
        {
            this.front = this.rear = -1; //-1 là out of nums, tức là chưa liên quan gì nums
            this.nums = new dynamic[initialSize];
        }
        private bool isFull()
        {
            //Lúc này rear tăng 1 thì sẽ bằng front, tức là rear sát đít front
            return (rear + 1) % nums.Length == front;
        }
        public bool isEmpty()
        {
            return front == -1; //front nằm ngoài nums, tức là trong mảng chưa có phần tử nào
        }
        private void resize()
        {
            dynamic[] tempArr = new dynamic[nums.Length * 2]; //Tăng kích thước để lưu nhiều data hơn
            int i = 0;  //Con trỏ cho mảng mới
            int j = front;
            // Mục đích là sao chép mảng cũ sang mảng mới, với mảng_cũ[front] sẽ là phần tử đầu tiên của mảng mới
            //Ví dụ: mảng_cũ = [1 ; 4 ; 2(front) ; 6 ; 7]
            //=> mảng_mới = [2(front) ; 6 ; 7 ; 1 ; 4(rear) ; null ; null ; null ; null ; null;] , size mới gấp đôi size cũ

            do
            {
                tempArr[i++] = nums[j];     //i có thể tăng bình thg
                j = (j + 1) % nums.Length;  //nhưng j ko được, do nums là mảng circle, j tăng theo vòng tròn 
            } while (j != front);
            front = 0;
            rear = nums.Length - 1;
            nums = tempArr;
        }
        public void Enqueue(dynamic data)
        {
            if (isFull())
            {
                //Nếu muốn tăng thì tăng, còn không thì có thể NoImplementation
                //resize();
                dynamic temp = Dequeue();
            }
            else if (isEmpty())
            {
                front++; //do empty là front đang = -1, chưa xuất phát -> chưa có dữ liệu trong queue
            }
            rear = (rear + 1) % nums.Length; //rear ++ theo kiểu vòng tròn\
                                             //Bản chất của Enqueue là thêm data, mà thêm là thêm vào rear, tức là chỉ số rear sẽ tăng.
            count++;
            nums[rear] = data;
        }
        public dynamic Dequeue()
        {
            if (isEmpty())
            {
                //Do nothing
            }
            int temp = nums[front];
            if (front == rear)
            {
                //Data đầy queue và chống lấn nhau;
                front = rear = -1;
            }
            else
            {
                front = (front + 1) % nums.Length;
            }
            return temp; //phần tử vừa bị loại ra khỏi queue
        }
        public dynamic Peek()
        {
            if (isEmpty())
            {
                throw new NotImplementedException();
            }
            else
            {
                return nums[rear];
            }
        }
        
    }

}
