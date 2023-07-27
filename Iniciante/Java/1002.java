import java.util.Scanner;
import java.util.Locale;

public class Main {

    public static void main(String[] args) {

        double pi = 3.14159;


        Scanner scanner = new Scanner(System.in).useLocale(Locale.US);
        double raio = scanner.nextDouble();
        scanner.close();

        double area = pi * Math.pow(raio, 2);

        System.out.println("A=" + String.format(Locale.US,"%.4f", area));
    }
}
