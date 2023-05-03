public class Program 
{
    internal class kelurahan
    {
        public enum Kelurahan
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Kebonwaru, Maleer, Samoja
        };

        public static int getKodePos(Kelurahan kelurahan)
        {
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodePos[(int)kelurahan];
        }
    }

    
        public enum doorState { TERBUKA, TERKUNCI };
        public enum doorTrigger { KUNCI_PINTU, BUKA_PINTU };

        class Door
        {
            public doorState currentState = doorState.TERKUNCI;
            public class Transition
            {
                public doorState currentState;
                public doorState finalState;
                public doorTrigger trigger;

                public Transition(doorState currentState, doorState finalState, doorTrigger trigger)
                {
                    this.currentState = currentState;
                    this.finalState = finalState;
                    this.trigger = trigger;
                }
            }
            Transition[] transisi =
            {
            new Transition(doorState.TERKUNCI, doorState.TERKUNCI, doorTrigger.KUNCI_PINTU),
            new Transition(doorState.TERBUKA,doorState.TERBUKA, doorTrigger.BUKA_PINTU),
            new Transition(doorState.TERKUNCI, doorState.TERBUKA, doorTrigger.BUKA_PINTU),
            new Transition(doorState.TERBUKA, doorState.TERKUNCI, doorTrigger.KUNCI_PINTU)

        };

            private doorState GetNextState(doorState currentState, doorTrigger trigger)
            {
                doorState finalState = currentState;
                for (int i = 0; i < transisi.Length; i++)
                {
                    Transition perubahan = transisi[i];
                    if (currentState == perubahan.currentState && trigger == perubahan.trigger)
                    {
                        finalState = perubahan.finalState;
                    }
                }
                return finalState;
            }
            public void ActivateTrigger(doorTrigger trigger)
            {
                currentState = GetNextState(currentState, trigger);
                Console.WriteLine("Kondisi pintu sekarang adalah " + currentState);


            }

        }
    
    private static void Main(string[] args) 
    {
        Door machine = new  Door();
        //Console.WriteLine(machine.currentState);
        machine.ActivateTrigger(doorTrigger.BUKA_PINTU);
        machine.ActivateTrigger(doorTrigger.BUKA_PINTU);
        machine.ActivateTrigger(doorTrigger.KUNCI_PINTU);
    }
}
