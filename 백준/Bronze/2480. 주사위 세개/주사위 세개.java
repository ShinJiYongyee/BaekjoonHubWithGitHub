import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int a= input.nextInt();
        int b= input.nextInt();
        int c= input.nextInt();

        boolean ab=a==b;
        boolean bc=b==c;
        boolean ca=c==a;

        if(ab&&bc)
            System.out.println(10000+a*1000);
        else if (ab&&!bc) {
            System.out.println(1000+a*100);
        } else if (!ab&&bc) {
            System.out.println(1000+b*100);
        } else if (ca&&!ab) {
            System.out.println(1000+c*100);
        }else{
            System.out.println(100*Math.max(Math.max(a,b),c));
        }


    }
}
