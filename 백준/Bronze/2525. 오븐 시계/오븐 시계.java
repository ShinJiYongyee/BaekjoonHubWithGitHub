import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int h1=input.nextInt();
        int m1=input.nextInt();
        int time=input.nextInt();

        int m2=(m1+time)%60;
        int h2=(h1+(m1+time)/60)%24;

        System.out.println(h2+" "+m2);


    }
}
