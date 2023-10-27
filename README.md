# WinUISharedSizeGroup
This repo implements WPF's useful `SharedSizeGroup` and `IsSharedSizeScope` in WinUI, but with some difference.

Here's an example showing how to use:

with ```xmlns:h="using:WinUISharedSizeGroup.Helpers"```
```xaml
<ListView ItemsSource="{x:Bind DataCollection}" h:ColumnSharedSizeHelper.IsSharedSizeScope="True"
          Width="400" VerticalAlignment="Center">
    <ListView.ItemTemplate>
        <DataTemplate>
            <Grid ColumnDefinitions="Auto,*">
                <TextBlock Text="{Binding Name}" VerticalAlignment="Center" h:ColumnSharedSizeHelper.SharedSizeGroup="SampleGroup"/>
                <TextBox Grid.Column="1" Text="{Binding Salary}"/>
            </Grid>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```

![effect](/screenshots/1.png)

# Difference
1. Requires the extra library `Microsoft.Xaml.Behaviors.WinUI.Managed`
2. Only for columns implemented in this repo, but most code can be reused for row's
3. `SharedSizeGroup` property is attached to the actual content rather than the `ColumnDefinition`, as we have no way to listen to `ColumnDefinition`'s size change
