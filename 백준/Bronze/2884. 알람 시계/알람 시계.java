import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int h1=input.nextInt();
        int m1=input.nextInt();
        int h2=h1, m2=m1-45;
        if(m1<45){
            h2=h1-1;
            m2=m1+60-45;
            if((h1-1)<0){
                h2=24+(h1-1);
            }
        }
       
        System.out.print(h2+" "+m2);
    }
}
