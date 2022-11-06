namespace Based{
        public class MyList<T> : List<T>{
        private T[] myList {get; set;} //variable that contains data of MyList class

        public MyList(){
            this.myList = new T[1]; // creates an 1-sized array by default
        }
        public MyList(int capacity = 1){ // creates a cystom-sized array
            this.myList = new T[capacity];
            }
        public int Capacity(){ //returns length of the array
            return this.myList.Length;
        }
        public void Add(T item){ //adds an element at the end of array
            if(myList[0] == null){
                myList[0] = item;
            }
            else{
                T[] newList = new T[myList.Length + 1];
                for(int i = 0; i < myList.Length; i++){
                    newList[i] = myList[i];
                }
                newList[newList.Length - 1] = item;
                this.myList = newList;
            }
        }
        public void Replace(int index, T element){
            try{
                myList[index] = element;
            }
            catch(IndexOutOfRangeException){
                Console.WriteLine("Out of range exception!!!!!");
            }
        }
        public T Indexator(int index){ //returns value of element by index
            return myList[index];
        }

    }
} 