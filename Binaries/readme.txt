Mam w tej chwili ju¿ pomys³, jak ulepszyæ bibliotekê klienck¹,
no ale trzeba iœæ spaæ. Tym niemniej...

JAK U¯YÆ W SWOJEJ APLIKACJI
1. Do³¹czyæ LoggingLib.dll
2. using MPLSSim_Logger
3. W inicjalizacji g³ównej klasy Twojego programu,
   dodaj linijkê:

   LoggingLib.Connect();

4. Nastêpnie, wysylasz na port 60000 stringi poprzez:

   LoggingLib.SendMessage(string msg);


JAK ODPALIÆ SERWER:
1. Zasugeruj siê plikiem start_60000.bat ;P