internal class Program
{
   
        public enum namaBuah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung , Kurma, Durian, Anggur, Melon, Semangka
        };


        public static string getKodeBuah(namaBuah namabuah)
        {

        string[] Kode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return Kode[(int)namabuah];
        }

   
        public enum characterState 
        {
            JONGKOK, BERDIRI, TENGKURAP, TERBANG
        }

        public enum characterTrigger
        {
            TOMBOL_S, TOMBOL_W, TOMBOL_X
        }

   class Game
        {
            public characterState currentState = characterState.BERDIRI;
    public class Transition
    {
        public characterState currentState;
        public characterState finalState;
        public characterTrigger trigger;

        public Transition(characterState currentstate, characterState finalState, characterTrigger trigger)
        {
            this.currentState = currentstate;
            this.finalState = finalState;
            this.trigger = trigger;
        }
    }
    Transition[] transisi =
    {
                new Transition(characterState.BERDIRI,characterState.JONGKOK, characterTrigger.TOMBOL_S),
                new Transition(characterState.BERDIRI,characterState.TERBANG, characterTrigger.TOMBOL_W),
                new Transition(characterState.TERBANG,characterState.BERDIRI, characterTrigger.TOMBOL_S),
                new Transition(characterState.TERBANG,characterState.JONGKOK, characterTrigger.TOMBOL_X),
                new Transition(characterState.TENGKURAP,characterState.JONGKOK, characterTrigger.TOMBOL_W),
                new Transition(characterState.JONGKOK,characterState.BERDIRI, characterTrigger.TOMBOL_W),
                new Transition(characterState.JONGKOK,characterState.TENGKURAP, characterTrigger.TOMBOL_S),
            };

    private characterState GetNextState(characterState currentState, characterTrigger trigger)
    {
        characterState finalState = currentState;
        for (int i = 0; i < transisi.Length; i++)
        {
            Transition change = transisi[i];
            if (currentState == change.currentState && trigger == change.trigger)
            {
                finalState = change.finalState;
                if (change.trigger == characterTrigger.TOMBOL_W)
                {
                    Console.WriteLine("tomboh arah atas ditekan");
                }
                if (change.trigger == characterTrigger.TOMBOL_S)
                {
                    Console.WriteLine("tombol arah bawah ditekan");
                }
            }
        }

        return finalState;

    }
    public void ActivateTrigger(characterTrigger trigger)
    {
        currentState = GetNextState(currentState, trigger);
        Console.WriteLine("Kondisi karakter sekarang adalah " + currentState);
    }

}


private static void Main(string[] args)
    {
        Console.WriteLine("AUTOMATA AND TABLE DRIVEN");

        Console.WriteLine();
        Console.WriteLine();

        namaBuah buah = namaBuah.Semangka;
        string kodeBuah = getKodeBuah(buah);
        Console.WriteLine("Kode buah " + buah + " adalah " + kodeBuah); 

        Console.WriteLine();
        Console.WriteLine();

        Game game = new Game();

        game.ActivateTrigger(characterTrigger.TOMBOL_W);
        game.ActivateTrigger(characterTrigger.TOMBOL_S);
        game.ActivateTrigger(characterTrigger.TOMBOL_S);
        game.ActivateTrigger(characterTrigger.TOMBOL_W);
    }

}
