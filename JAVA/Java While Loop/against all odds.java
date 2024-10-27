import java.util.Scanner;

class Main {
	public static void main(String args[]) {
        
		Scanner input = new Scanner(System.in);
        int i = 1;
		int n = input.nextInt();

		while(n >= i) {
            if((n % 2 )!=0 ){
            System.out.println(n);
            }

            n--;

		}

	}
}