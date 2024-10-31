import java.util.Scanner;

class Main{
    public static void main(String args[]){
        Scanner input = new Scanner(System.in);

       int a = 0,b = 0, c;

        do{
            c = input.nextInt();
            b++;
            if (c > 0) {
                a += c;
                
            }
        }
            while(c!=0);
        System.out.println(a);
  }
}