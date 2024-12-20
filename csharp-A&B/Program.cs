/*
 
A – Rispondi alle seguenti domande argomentando la risposta:

    1) Cos’è un linguaggio di programmazione?

        Un linguaggio di programmazione è una serie di comandi scritti secondo una particolare sintassi e semantica
        aventi lo scopo di impartire al computer determinate istruzioni al fine di fargli eseguire uno o più compiti
        specifici

    2) Definisci il linguaggio C#.
        
       Il C# è un tipo di linguaggio di programmazione fortemente tipizzato,case sensitive,abbastanza moderno e altamente versatile per
       una grande varietà di compiti.


    3) Cosa si intende per programmazione procedurale?
        
       La programmazione procedurale è un paradigma (metodologia) di programmazione che prevede la suddivisione dei compiti tra le varie 
       funzioni (procedure) che vengono richiamate secondo una sequenza prestabilita. Uno degli svantaggi principali è la mantenibilità del codice
       all'aumentare della complessità

    4) Cos’è un linguaggio orientato agli oggetti?
        
       La Programmazione Orientata agli Oggetti è un paradigma che organizza il codice attorno a classi (modelli) e oggetti (istanze delle classi).
       Ogni oggetto rappresenta un'entità autonoma che combina dati (attributi) e comportamenti (metodi), rendendolo l'elemento centrale su cui si basa questa metodologia.
       L'approccio mira a garantire determinati vantaggi in particolare: 
            1) modularità (Il codice è suddiviso in blocchi autonomi (classi e oggetti), facilitando l'organizzazione e la comprensione),
            2) Riutilizzo del Codice (Le classi possono essere riutilizzate in diversi contesti o progetti),
            3) Isolamento (Gli oggetti sono indipendenti e i dettagli implementativi sono nascosti grazie all'incapsulamento),
            4) Estensibilità (Grazie a concetti come ereditarietà e polimorfismo, il codice può essere facilmente adattato o esteso per nuove funzionalità).

    5) Quali sono le caratteristiche principali di C#.

       C# risulta essere:
        1)fortemente tipizzato
        2)Case Sansitive
        3)orientato agli oggetti
        4)Facile da implementare
        5)Con una sintassi moderna e intuitiva

    6) Cos’è una variabile?

       una varibile è un contenitore (spazio di memoria riservato),
       nel quale salviamo un'informazione fino a quando un programma rimane in esecuzione


    7) Cosa si intende per Intermidiate Language?
        
      è un linguaggio intermedio che si trova tra il codice scritto dall'essere umano e il codice macchina eseguibile dal Computer.
      Rappresenta la conversione intermedia dei comandi scritti dall'operatore che devono essere convertiti in linguaggio macchina per
      essere successivamente eseguiti da un compilatore


    8) È possibile creare un progetto dal prompt dei comandi? Se si spiega come.
      
        Si è possibile, in questo modo:

        Dopo aver creato la propria cartella, aperto il promp,istallato dotnet,essersi spostati nella cartella, digitare: dotnet new Es console
    
    9) Come si aggiunge un commento nel linguaggio C#?
        
        in C# è possibile aggiungere un commento in due modi:

            1) //

            2)/**/

/*
    10) La sigla IDE cosa rappresenta?

        IDE sta per (Integrated Developement Environment) è l'ambiente di sviluppo dei vari progetti che fornisce tutta una serie di strumenti utili per questa mansione.

--------------------------------------------------------------------------
B – Esercizi C#

    1) Creare 4 metodi: uno per la somma, uno per la sottrazione, uno per la moltiplicazione e uno per
    la divisione tra due numeri. Ognuno di questi metodi deve restituire il risultato dell’operazione.
    Inserire nella classe col metodo Main delle stampe dei risultati come esempio.

    2) Creare un metodo che stampi a schermo il calcolo della media tra 3 numeri

    3) Scrivere la classe Dipendente e la classe Manager con costruttore vuoto e costruttore
    parametrizzato, individuando almeno 3 attributi e un metodo (ad esempio presentati()).

    4) Istanziare almeno due oggetti con le classi create nell’esercizio 3 e fare degli esempi con i
    metodi.

    5) Creare una classe Cerchio con una variabile chiamata raggio. La classe deve avere un metodo che
    calcoli la circonferenza ed un altro metodo che calcoli l’area del cerchio. Inserire nella classe col
    metodo Main qualche esempio. Utilizzare una costante chiamata PI_GRECO che valga 3,14.

*/

using System.Net.Http.Headers;

namespace csharp_A_B
{
    internal class Program
    {
        // Metodo per la somma
        static int Somma(int a, int b)
        {
            return a + b;
        }

        // Metodo per la sottrazione
        static int Sottrazione(int a, int b)
        {
            return a - b;
        }

        // Metodo per la prodotto
        static int Prodotto(int a, int b)
        {
            return a * b;
        }

        // Metodo per la divisione
        static double Divisione(int a, int b)
        {
            return a / b;
        }

        static void Media(int a, int b, int c)
        {
            Console.WriteLine("\nPrimo numero: {0}", a);
            Console.WriteLine("\nSecondo numero: {0}", b);
            Console.WriteLine("\nTerzo numero: {0}", c);
            Console.WriteLine("\nMedia: {0}", (a + b + c) / 3);
        }

        static void Main(string[] args)
        {

            //ESERCIZIO 1
            int num1 = 9, num2 = 5;

            Console.WriteLine("La somma sarà: {0}", Somma(num1, num2));

            Console.WriteLine("La sottrazione sarà: {0}", Sottrazione(num1, num2));

            Console.WriteLine("Il prodotto sarà: {0}", Prodotto(num1, num2));

            Console.WriteLine("La divisione sarà: {0}", Divisione(num1, num2));


            //ESERCIZIO 2
            Media(5, 17, 36);


            //ESERCIZIO 3 - 4
            Dipendente persona1 = new Dipendente("Claudio", "58KYT81", 25);

            //metodo non statico
            persona1.Presentati();

            //metodo statico
            Dipendente.Presentati("Mario", "23AFX91", 43);

            Manager persona2 = new Manager("Dario", "51PTY84", "Supervisore trasporti");

            //metodo non statico
            persona2.Presentati();

            //ESERCIZIO 5

            Cerchio prova1 = new Cerchio(5.389);

            prova1.StampaVideo();

        }

        public class Dipendente
        {
            // Attributi
            public string Nome;
            public string Matricola;
            public int Anni;

            // Costruttore vuoto
            public Dipendente()
            {

            }

            // Costruttore parametrizzato
            public Dipendente(string Nome, string Matricola, int Anni)
            {
                this.Nome = Nome;
                this.Matricola = Matricola;
                this.Anni = Anni;
            }

            // Metodo non statico per presentarsi
            public void Presentati()
            {
                Console.WriteLine($"\nCiao sono {this.Nome}, e ho {this.Anni} anni.");
            }
            // Metodo statico per presentarsi
            public static void Presentati(string Nome, string Matricola, int Anni)
            {
                Console.WriteLine("\nBuongiorno mi chaimo {0}, numero di matricola:{1} e ho:{2}.", Nome, Matricola, Anni);
            }
        }

        public class Manager
        {
            // Attributi
            public string Nome;
            public string Matricola;
            public string Mansione;

            // Costruttore vuoto
            public Manager()
            {
            }

            // Costruttore parametrizzato
            public Manager(string Nome, string Matricola, string Mansione)
            {
                this.Nome = Nome;
                this.Matricola = Matricola;
                this.Mansione = Mansione;
            }
            // Metodo non statico per presentarsi
            public void Presentati()
            {
                Console.WriteLine($"\nCiao sono {this.Nome}, e sono {this.Mansione}.");
            }
            // Metodo statico per presentarsi
            public static void Presentati(string Nome, string Matricola, string Mansione)
            {
                Console.WriteLine("\nBuongiorno mi chaimo {0}, numero di matricola:{1} e ricopro il ruolo:{2}.", Nome, Matricola, Mansione);
            }
        }

        public class Cerchio
        {
            // Attributi
            public double Raggio;

            // Costante per il valore di Pi greco
            const float PI_GRECO = 3.14f;


            // Costruttore vuoto
            public Cerchio()
            {
            }

            // Costruttore parametrizzato
            public Cerchio(double Raggio)
            {

                this.Raggio = Raggio;

            }

            // Metodo per calcolare la circonferenza
            public float CalcolaCirconferenza()
            {
                return (float)(2 * PI_GRECO * Raggio);
            }

            // Metodo per calcolare l'area
            public float CalcolaArea()
            {
                return (float)(PI_GRECO * Raggio * Raggio);
            }

            // Metodo per stampare a video circonferenza e area
            public void StampaVideo()
            {
                Console.WriteLine($"\nla circonferenza del cerchio sarà uguale a:{CalcolaCirconferenza()}, e l'area a:{CalcolaArea()}.");
            }

        }

    }
}