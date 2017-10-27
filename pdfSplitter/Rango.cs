namespace pdfSplitter
{
    public class Rango
    {
        private int inicio;
        private int fin;

        public Rango(int inicio, int fin)
        {
            this.inicio = inicio;
            this.fin = fin;
        }

        public override string ToString()
        {
            return inicio + " - " + fin;
        }

    }
}
