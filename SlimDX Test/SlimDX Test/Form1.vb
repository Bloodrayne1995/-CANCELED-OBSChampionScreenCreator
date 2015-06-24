Imports SlimDX.Windows
Imports SlimDX.Direct3D11
Imports SlimDX.DXGI
Imports SlimDX
Imports System.Threading

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckForIllegalCrossThreadCalls = False
        Dim x As New Thread(AddressOf test)
        x.Start()
    End Sub


    Sub test()
        Dim x As New RenderForm("Mein erstes SlimDX Fenster")
        x.Width = 600
        x.Height = 600

        Dim d As New SwapChainDescription
        With d
            .BufferCount = 1
            .Usage = Usage.RenderTargetOutput
            .OutputHandle = x.Handle
            .IsWindowed = True
            .ModeDescription = New ModeDescription(0, 0, New Rational(60, 1), Format.B8G8R8A8_UNorm)
            .SampleDescription = New SampleDescription(1, 0)
            .Flags = SwapChainFlags.AllowModeSwitch
            .SwapEffect = SwapEffect.Discard
        End With

        Dim a As SlimDX.Direct3D11.Device
        Dim s As SwapChain
        SlimDX.Direct3D11.Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.None, d, a, s)
        Dim r As RenderTargetView
        r = New RenderTargetView(a, SlimDX.Direct3D11.Resource.FromSwapChain(Of Texture2D)(s, 0))
        Dim context As SlimDX.Direct3D11.DeviceContext = a.ImmediateContext
        Dim viewPort As New Viewport(0.0F, 0.0F, x.ClientSize.Width, x.ClientSize.Height)
        context.OutputMerger.SetTargets(r)
        context.Rasterizer.SetViewports(viewPort)

        Dim factory As Factory = s.GetParent(Of Factory)()
        factory.SetWindowAssociation(x.Handle, WindowAssociationFlags.IgnoreAltEnter)

        MessagePump.Run(x, Sub()
                               context.ClearRenderTargetView(r, New Color4(0, 0, 255))
                               s.Present(0, PresentFlags.None)
                           End Sub)

        'x.ShowDialog()


        Dim tst As New PictureBox
        tst.Size = New Size(200, 200)
        tst.BackgroundImageLayout = ImageLayout.Stretch
        tst.BackgroundImage = Image.FromFile("C:\Users\Bloodrayne\SkyDrive\Bilder\Wallpaper\Games\minecraft-game-hd-wallpaper-1920x1080-10005.jpg", False)
        tst.Location = New Point(0, 0)

        x.Controls.Add(tst)

        r.Dispose()
        s.Dispose()
        a.Dispose()
    End Sub
End Class
