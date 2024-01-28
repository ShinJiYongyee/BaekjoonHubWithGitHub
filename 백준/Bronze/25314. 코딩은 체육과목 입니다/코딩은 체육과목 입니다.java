import java.util.Scanner;


public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int Z= input.nextInt();
        for (int i = 0; i < Z/4; i++) {
            System.out.print("long ");
        }
        System.out.println("int");
    }
}
