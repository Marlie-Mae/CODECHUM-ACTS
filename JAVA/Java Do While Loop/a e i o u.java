import java.util.Scanner;

class Main{
    public static void main(String args[]){
        Scanner input = new Scanner(System.in);

        int a = 0;
        char b;

        do{
            b= input.next().charAt(0);
            a++;
            System.out.println(b);
        } 
            while((b !='a') && (b !='e') && (b !='i') && (b !='o') && (b !='u') && (a != 5));
  }
}