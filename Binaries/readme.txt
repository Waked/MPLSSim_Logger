Mam w tej chwili ju� pomys�, jak ulepszy� bibliotek� klienck�,
no ale trzeba i�� spa�. Tym niemniej...

JAK U�Y� W SWOJEJ APLIKACJI
1. Do��czy� LoggingLib.dll
2. using MPLSSim_Logger
3. W inicjalizacji g��wnej klasy Twojego programu,
   dodaj linijk�:

   LoggingLib.Connect();

4. Nast�pnie, wysylasz na port 60000 stringi poprzez:

   LoggingLib.SendMessage(string msg);


JAK ODPALI� SERWER:
1. Zasugeruj si� plikiem start_60000.bat ;P