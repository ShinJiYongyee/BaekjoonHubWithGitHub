import java.util.Scanner;


public class Main {

    public static void main(String[] args) {
        Scanner input=new Scanner(System.in);
        int T=input.nextInt();
        int n=0;
        int [] result=new int[T];
        while(n<T){
            int a= input.nextInt();
            int b= input.nextInt();
            result[n]=a+b;
            n++;
        }
        for (int i = 0; i <T ; i++) {
            System.out.println(result[i]);
        }
    }
}
