import java.util.Scanner;

class Main{
    public static void main(String args[]){
        Scanner input = new Scanner(System.in);

        float a = 0, b = 0, c;

        do {
            c =  input.nextFloat();
            a += c;
            b++;
        }
            while ((c !=0) && (a <100) && (c > 0));
        System.out.println(String.format("%.2f", a));
  }
}