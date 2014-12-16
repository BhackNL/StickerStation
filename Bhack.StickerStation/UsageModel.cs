
namespace Bhack.StickerStation
{
    public class UsageModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool HasFee { get; set; }

        public UsageModel(int id, string text, bool hasFee)
        {
            Id = id;
            Text = text;
            HasFee = hasFee;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
