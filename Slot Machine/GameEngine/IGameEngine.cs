namespace Slot_Machine;

public interface IGameEngine
{
    public int GameBalance { get; set; }

    void DepositAccount();

    void Play();
}