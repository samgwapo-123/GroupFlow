namespace GroupFlow;

// Tailwind class strings used in several pages.
public static class Ui
{
    public const string Card = "rounded-xl border border-line bg-card p-5";
    public const string Badge = "rounded-full border px-2.5 py-0.5 text-xs";
    public const string Field = "w-full rounded-lg border border-line bg-bg px-3 py-2 text-sm outline-none focus:border-accent";
    public const string Primary = "rounded-lg bg-accent px-4 py-2 text-sm font-semibold text-bg hover:opacity-90";
    public const string Secondary = "rounded-lg border border-line px-4 py-2 text-sm text-gray-300 hover:bg-white/5";

    public static string Status(string s) => s switch
    {
        "Done" => "text-ok border-ok/30 bg-ok/10",
        "In Progress" => "text-warn border-warn/30 bg-warn/10",
        _ => "text-muted border-line bg-white/5"
    };

    public static string Priority(string p) => p switch
    {
        "High" => "text-bad border-bad/30 bg-bad/10",
        "Medium" => "text-warn border-warn/30 bg-warn/10",
        _ => "text-muted border-line bg-white/5"
    };
}