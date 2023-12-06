import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);

        int a= input.nextInt();
        boolean c1=(a%4)==0;
        boolean c2=(a%100)==0;
        boolean c3=(a%400)==0;

        if(c1&&!c2) System.out.println(1);
        else if(c3) System.out.println(1);
        else System.out.println(0);

    }

}
