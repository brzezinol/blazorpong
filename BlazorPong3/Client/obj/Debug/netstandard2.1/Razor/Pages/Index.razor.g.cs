#pragma checksum "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0d98cb12226574fc710119f1e780ae0350d1166"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPong3.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\_Imports.razor"
using BlazorPong3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\_Imports.razor"
using BlazorPong3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
using BlazorPong3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"net\"></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "ball rounded-circle");
            __builder.AddAttribute(3, "style", "top:" + " " + (
#nullable restore
#line 8 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                                              BallTop

#line default
#line hidden
#nullable disable
            ) + ";left:" + (
#nullable restore
#line 8 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                                                            BallLeft

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "l-palette");
            __builder.AddAttribute(7, "style", "top:" + " " + (
#nullable restore
#line 9 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                                    lPaletteTop

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "r-palette");
            __builder.AddAttribute(11, "style", "top:" + " " + (
#nullable restore
#line 10 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                                    rPaletteTop

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "debug");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddContent(17, "Connected:");
            __builder.AddContent(18, 
#nullable restore
#line 12 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                    IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddContent(21, "Player:");
            __builder.AddContent(22, 
#nullable restore
#line 13 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                 PlayerID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddContent(25, 
#nullable restore
#line 14 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
          ballLeft

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, ";");
            __builder.AddContent(27, 
#nullable restore
#line 14 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                    ballTop

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 15 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
      
        foreach (var m in messages)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "            ");
            __builder.OpenElement(30, "div");
            __builder.AddContent(31, 
#nullable restore
#line 18 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                  m

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 19 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
        }
    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal");
            __builder.AddAttribute(36, "id", "myModal");
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "modal-dialog");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-content");
            __builder.AddMarkupContent(43, "\r\n\r\n            \r\n            ");
            __builder.AddMarkupContent(44, "<div class=\"modal-header\">\r\n                <h4 class=\"modal-title\">Enter username</h4>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n            </div>\r\n\r\n            \r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "modal-body");
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "id", "bookToDeleteField");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                                                                       UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserName = __value, UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n            \r\n            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal-footer");
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.AddMarkupContent(58, "<button type=\"button\" class=\"btn\" data-dismiss=\"modal\">Cancel</button>\r\n                ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn btn-success");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
                                                                        StartClient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(63, "Ok");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Piotrek\source\repos\BlazorPong\BlazorPong3\Client\Pages\Index.razor"
      
    public class PlaneDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    [Inject]
    IJSRuntime JS { get; set; }

    [Inject]
    NavigationManager NavigationManager { get; set; }

    int ballTop = 55;
    int ballLeft = 0;
    int ballVelocityX = 4;
    int ballVelocityY = 4;

    static int planeWidth = 0;
    static int planeHeight = 0;

    public string BallTop { get; set; }
    public string BallLeft { get; set; }

    static int _lPaletteTop { get; set; }
    static int _rPaletteTop { get; set; }
    public string lPaletteTop { get; set; }
    public string rPaletteTop { get; set; }

    private string _userInput;
    private string _messageInput;
    static bool _isPlayerOne = false;
    public string PlayerID { get; set; }
    static bool requestPlaneSize = false;
    public bool GameStarted { get; set; } = false;

    System.Timers.Timer runingTimer = new System.Timers.Timer();

    public string UserName { get; set; }

    HubConnection hubConnection;
    List<string> messages = new List<string>();

    public bool IsConnected => hubConnection?.State == HubConnectionState.Connected;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        BallTop = $"{ballTop}px";
        BallLeft = $"{ballLeft}px";

        runingTimer.Interval = 25;
        runingTimer.Elapsed += OnTimerElapsed;

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/gameHub"))
            .Build();

        hubConnection.On<string, string>(SignalRMessages.RECEIVE, (user, message) =>
        {
            Console.WriteLine($"RECEIVE:{message}");
            HandleReceiveMessage(user, message);
        });

        hubConnection.On<string, string>(SignalRMessages.BALL_POSITION, (user, message) =>
        {
            if (!_isPlayerOne)
            {
                var position = message.Split(';');
                ballLeft = int.Parse(position[0]);
                ballTop = int.Parse(position[1]);
            }
        });

        hubConnection.On<string, string>(SignalRMessages.PLAYER_ID, async (user, message) =>
        {
            Console.WriteLine($"PLAYER_ID:{message}");
            if (message == "1")
            {
                _isPlayerOne = true;
                PlayerID = "1";
            }
            else
            {
                _isPlayerOne = false;
                PlayerID = "2";

                await hubConnection.SendAsync(SignalRMessages.START_GAME, UserName);

                GameStarted = true;

                runingTimer.Start();
            }
        });

        hubConnection.On<string, string>(SignalRMessages.START_GAME, async (user, message) =>
        {
            GameStarted = true;

            runingTimer.Start();
        });

        await hubConnection.StartAsync();
    }

    protected override async void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        if (firstRender)
        {
            if (await JS.InvokeAsync<bool>("enterUserName"))
            {

                var dimensions = await JS.InvokeAsync<PlaneDimension>("getPlaneSize");
                planeWidth = dimensions.Width;
                planeHeight = dimensions.Height;

                ballLeft = planeWidth / 2 - 20;
                ballTop = planeHeight / 2 - 20;

                BallTop = $"{ballTop}px";
                BallLeft = $"{ballLeft}px";

                _lPaletteTop = planeHeight / 2 + 60;
                _rPaletteTop = planeHeight / 2 + 60;
            }
        }
    }

    public void Destroy()
    {
        runingTimer.Stop();
    }

    async void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        if (requestPlaneSize)
        {
            requestPlaneSize = false;
            var dimensions = await JS.InvokeAsync<PlaneDimension>("getPlaneSize");
            planeWidth = dimensions.Width;
            planeHeight = dimensions.Height;
        }

        if (_isPlayerOne)
        {
            ballTop += ballVelocityY;
            ballLeft += ballVelocityX;
        }

        BallTop = $"{ballTop}px";
        BallLeft = $"{ballLeft}px";

        lPaletteTop = $"{_lPaletteTop}px;";
        rPaletteTop = $"{_rPaletteTop}px;";

        if (_isPlayerOne)
        {
            //bottom
            if (ballTop + 20 >= planeHeight || ballTop <= 55)
            {
                ballVelocityY *= -1;
            }

            //right
            if (ballLeft + 20 >= planeWidth || ballLeft <= 0)
            {
                ballVelocityX *= -1;
            }

            await SendBallPositionAsync();
        }

        StateHasChanged();
    }

    [JSInvokable]
    public static Task OnWindowResize()
    {
        requestPlaneSize = true;

        return Task.CompletedTask;
    }

    [JSInvokable]
    public static Task OnKeyDown(int key)
    {
        switch (key)
        {
            case 38:
                if (_isPlayerOne)
                {
                    _lPaletteTop -= 5;
                }
                else
                {
                    _rPaletteTop -= 5;
                }
                break;
            case 40:
                if (_isPlayerOne)
                {
                    _lPaletteTop += 5;
                }
                else
                {
                    _rPaletteTop += 5;
                }
                break;
            case 27:
                if (_isPlayerOne)
                {

                }
                else
                {

                }
                break;
        }

        return Task.CompletedTask;
    }

    public async Task StartClient()
    {
        Console.WriteLine($"UserName:{UserName}");
        if (!string.IsNullOrEmpty(UserName))
        {
            await JS.InvokeAsync<bool>("hideUserNameDialog");

            await hubConnection.SendAsync(SignalRMessages.REGISTER, UserName);
        }
        else
        {
            Console.WriteLine($"UserName:{UserName}");
        }
    }

    private void HandleReceiveMessage(string username, string message)
    {
        messages.Add($"{username}:{message}");

        StateHasChanged();
    }

    public async Task SendAsync(string message)
    {
        // check we are connected
        if (hubConnection.State != HubConnectionState.Connected)
            throw new InvalidOperationException("Client not started");
        // send the message
        await hubConnection.SendAsync(SignalRMessages.SEND, UserName, message);
    }

    public async Task SendBallPositionAsync()
    {
        // check we are connected
        if (hubConnection.State != HubConnectionState.Connected)
            throw new InvalidOperationException("Client not started");
        // send the message
        await hubConnection.SendAsync(SignalRMessages.BALL_POSITION, UserName, $"{ballLeft};{ballTop}");
    }

    public async Task StopAsync()
    {
        if (hubConnection.State == HubConnectionState.Connected)
        {
            // disconnect the client
            await hubConnection.StopAsync();
            // There is a bug in the mono/SignalR client that does not
            // close connections even after stop/dispose
            // see https://github.com/mono/mono/issues/18628
            // this means the demo won't show "xxx left the chat" since 
            // the connections are left open
            await hubConnection.DisposeAsync();
            hubConnection = null;
        }
    }

    public async ValueTask DisposeAsync()
    {
        Console.WriteLine("ChatClient: Disposing");
        await StopAsync();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591