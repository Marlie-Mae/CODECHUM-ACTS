import java.util.Scanner;
public class Main {
    public static void main (String args[]) {
        Scanner input = new Scanner(System.in);
        int a = input.nextInt();
        int num = input.nextInt();
        int count = 0;

        while (num > 0) {
            if(num % 10 == a) {
                count++;
            }
            num /= 10;
        }
        System.out.println(count);
    }
}