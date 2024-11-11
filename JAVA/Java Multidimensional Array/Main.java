import java.util.Arrays;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter the number of rows for the multidimensional array: ");
        int rows = scanner.nextInt();
        System.out.print("Enter the number of columns for the multidimensional array: ");
        int columns = scanner.nextInt();

        String[][] multiArray = new String[rows][columns];

        System.out.println("Enter data into the multidimensional array:");
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                System.out.print("Enter data for position [" + i + "][" + j + "]: ");
                multiArray[i][j] = scanner.next();
            }
        }

        System.out.println("\nOriginal multidimensional array:");
        printArray(multiArray);

        sortArray(multiArray);

        System.out.println("\nSorted multidimensional array:");
        printArray(multiArray);

        System.out.print("\nEnter a name to search: ");
        String searchName = scanner.next();

        if (searchArray(multiArray, searchName)) {
            System.out.println("Name found in the array.");
        } else {
            System.out.println("Name not found in the array.");
        }

        scanner.close();
    }

    public static void printArray(String[][] array) {
        for (String[] row : array) {
            System.out.println(Arrays.toString(row));
        }
    }

    public static void sortArray(String[][] array) {
        for (String[] row : array) {
            Arrays.sort(row);
        }
    }

    public static boolean searchArray(String[][] array, String name) {
        for (String[] row : array) {
            if (Arrays.asList(row).contains(name)) {
                return true;
            }
        }
        return false;
    }
}
