namespace PointLib{
	public class Point{
		private double x=0;
		private double y=0;
		
		public Point(System.Double x, System.Double y){
			this.x=x;
			this.y=y;
		}
		
		public System.Double getModule(){
			return System.Math.Sqrt(x*x+y*y);
		}
	}
}