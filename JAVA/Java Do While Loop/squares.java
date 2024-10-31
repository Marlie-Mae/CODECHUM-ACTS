import java.util.Scanner;

class Main{
    public static void main(String args[]){
        Scanner input = new Scanner(System.in);

        int a;
        int b = 0;

        do{
            a = input.nextInt();
            b = a * a;
            System.out.println(b);
        } while(a!=0);
  }
}