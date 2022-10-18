namespace TriangleFrac
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        private Point[] vertexes;
        private Point currentLocation;
        const double HeightWidthRation = 0.87;
        public Form1()
        {
            InitializeComponent();
            
            pushButton.Click += createTriangle;
        }
        private int SideLength()
        {
            int height = (int)Math.Min((double)triangle.Width, triangle.Height / HeightWidthRation);
            return (int)height;
        }
        private void SetPointLocations(int sideLength)
        {
            Point midPoint = new Point(triangle.Width / 2, triangle.Height / 2);
            vertexes = new Point[3];
            vertexes[0] = new Point(midPoint.X,
                midPoint.Y - (int)(sideLength * HeightWidthRation / 2));
            vertexes[1] = new Point(midPoint.X - sideLength / 2,
                midPoint.Y + (int)(sideLength * HeightWidthRation / 2));
            vertexes[2] = new Point(midPoint.X + sideLength / 2,
                midPoint.Y + (int)(sideLength * HeightWidthRation / 2));
        }

        private void DrawPoint(Point currentLocation, Graphics g)
        {
            Brush b = new SolidBrush(Color.Black);
            g.FillRectangle(b, currentLocation.X, currentLocation.Y, 1, 1); // create dote
        }
        
        private void DrawNextPoint(Graphics graph)
        {
            GetMidPoint();
            DrawPoint(currentLocation, graph);
            Application.DoEvents();
        }

        private void GetMidPoint()
        {
            int vertex = random.Next(0, 3);
            currentLocation.X = (currentLocation.X + vertexes[vertex].X) / 2;
            currentLocation.Y = (currentLocation.Y + vertexes[vertex].Y) / 2;
        }
        private void createTriangle(object sender, EventArgs e)
        {
            triangle_Paint();
        }
        private void triangle_Paint()
        {
            Graphics graph = triangle.CreateGraphics();
            int sideLength = SideLength();
            SetPointLocations(sideLength);
            for (int i =0;i<Convert.ToInt32(numDotes.Text);i++){
                DrawNextPoint(graph);       
            }
        }
    }
}