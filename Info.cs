namespace app
{
    public class Info
    {
        public double N { get; private set; }
        public double M { get; private set; }
        public double D { get; private set; }
        public double H { get; private set; }
        public double DBT { get; private set; }
        public double RH { get; private set; }
        public double HR { get; private set; }
        public double WS { get; private set; }
        public double WD { get; private set; }
        public double ITH { get; private set; }
        public double IDH { get; private set; }
        public double ISH { get; private set; }
        public double TSKY { get; private set; }
        public double N__0 { get; private set; }
        public double N__30 { get; private set; }
        public double NE_30 { get; private set; }
        public double E__30 { get; private set; }
        public double SE_30 { get; private set; }
        public double S__30 { get; private set; }
        public double SW_30 { get; private set; }
        public double W__30 { get; private set; }
        public double NW_30 { get; private set; }
        public double N__45 { get; private set; }
        public double NE_45 { get; private set; }
        public double E__45 { get; private set; }
        public double SE_45 { get; private set; }
        public double S__45 { get; private set; }
        public double SW_45 { get; private set; }
        public double W__45 { get; private set; }
        public double NW_45 { get; private set; }
        public double N__60 { get; private set; }
        public double NE_60 { get; private set; }
        public double E__60 { get; private set; }
        public double SE_60 { get; private set; }
        public double S__60 { get; private set; }
        public double SW_60 { get; private set; }
        public double W__60 { get; private set; }
        public double NW_60 { get; private set; }
        public double N__90 { get; private set; }
        public double NE_90 { get; private set; }
        public double E__90 { get; private set; }
        public double SE_90 { get; private set; }
        public double S__90 { get; private set; }
        public double SW_90 { get; private set; }
        public double W__90 { get; private set; }
        public double NW_90 { get; private set; }

        public static Info CreateFromLine(double[] line)
        {
            return new Info
            {
                N = line[0],
                M = line[1],
                D = line[2],
                H = line[3],
                DBT = line[4],
                RH = line[5],
                HR = line[6],
                WS = line[7],
                WD = line[8],
                ITH = line[9],
                IDH = line[10],
                ISH = line[11],
                TSKY = line[12],
                N__0 = line[13],
                N__30 = line[14],
                NE_30 = line[15],
                E__30 = line[16],
                SE_30 = line[17],
                S__30 = line[18],
                SW_30 = line[19],
                W__30 = line[20],
                NW_30 = line[21],
                N__45 = line[22],
                NE_45 = line[23],
                E__45 = line[24],
                SE_45 = line[25],
                S__45 = line[26],
                SW_45 = line[27],
                W__45 = line[28],
                NW_45 = line[29],
                N__60 = line[30],
                NE_60 = line[31],
                E__60 = line[32],
                SE_60 = line[33],
                S__60 = line[34],
                SW_60 = line[35],
                W__60 = line[36],
                NW_60 = line[37],
                N__90 = line[38],
                NE_90 = line[39],
                E__90 = line[40],
                SE_90 = line[41],
                S__90 = line[42],
                SW_90 = line[43],
                W__90 = line[44],
                NW_90 = line[45]
            };
        }
    }
}

