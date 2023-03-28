# MAUI_01_LayoutExam
.NET MAUI Layout 연습 (Maui Korea Developer 1차 실습자료)

<img width="515" alt="image" src="https://user-images.githubusercontent.com/68939699/226964333-619338e2-c7fd-4ee7-a76e-bd7dd6c5c8bc.png">

참고: 마소문서 https://learn.microsoft.com/ko-kr/dotnet/maui/user-interface/layouts/?view=net-maui-7.0

## 1. Grid Layout 연습 - Views.GridLayoutPage.xaml

![image](https://user-images.githubusercontent.com/68939699/226965017-b988dd3f-379d-430f-8bc2-775757aff30f.png)

## 2. BindableLayout 연습 - Views.BindableLayoutPage.xaml

참고: 
마소문서 https://learn.microsoft.com/ko-kr/dotnet/maui/user-interface/layouts/bindablelayout?view=net-maui-7.0

기초연습: https://github.com/kangsong77/MAUI_01_01_BindableLayout.App 

![image](https://user-images.githubusercontent.com/68939699/228288294-485b7fb6-fd8e-4364-80c7-d0fc80a3f94f.png)

```
<!-- [아이템]: 4x2-->
<Grid Grid.Row="1" RowDefinitions="auto, auto" >
    <StackLayout Grid.Row="0" Orientation="Horizontal" 
                 BindableLayout.ItemsSource="{Binding Items1}">
        <BindableLayout.ItemTemplate>
            <DataTemplate>
                <StackLayout Margin="6, 0, 6, 0">
                    <BoxView Color="#E3E4E7" HeightRequest="70" WidthRequest="70"></BoxView>
                    <Label Text="{Binding}" HorizontalOptions="Center" Margin="0,10,0,0"></Label>
                </StackLayout>
            </DataTemplate>
        </BindableLayout.ItemTemplate>
    </StackLayout>
    <StackLayout Grid.Row="1" Orientation="Horizontal" Margin="0,10,0,0"
                 BindableLayout.ItemsSource="{Binding Items2}">
        <BindableLayout.ItemTemplate>
            <DataTemplate>
                <StackLayout Margin="6, 0, 6, 0">
                    <BoxView Color="#E3E4E7" HeightRequest="70" WidthRequest="70"></BoxView>
                    <Label Text="{Binding}" HorizontalOptions="Center" Margin="0,10,0,10"></Label>
                </StackLayout>
            </DataTemplate>
        </BindableLayout.ItemTemplate>
    </StackLayout>
</Grid>
```


