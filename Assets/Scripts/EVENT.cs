using System;

public static class EVENT

{

    public static Action<int> number;   //событие, на которое будет подписка

    public static void ZvonokSobitie(int numberSobitie)  //метод оповещения, о том что событие произошло

    {
        number?.Invoke(numberSobitie);    //оповещение, о том что событие произошло (? означает, что команда выполнится только если хоть кто-то подписан)
    }

}