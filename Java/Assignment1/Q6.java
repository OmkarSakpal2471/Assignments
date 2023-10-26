package Day1;

public class Q6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		for(int i=3;i<=30;i=i+2) {
			boolean flag = true;
			for(int j=2;j<i/2;j++) {
				if(i%j==0) {
					flag=false;
					break;
				}
			}
			if (flag)
				System.out.println(i);
		}
	}
}
