import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int a= input.nextInt();
        int b= input.nextInt();
        boolean A=a>0;
        boolean B=b>0;
        if(A&&B) System.out.println(1);
        if(!A&&B) System.out.println(2);
        if(!A&&!B) System.out.println(3);
        if(A&&!B) System.out.println(4);

    }

}
