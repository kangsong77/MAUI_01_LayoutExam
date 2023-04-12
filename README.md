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

## 3. FlexLayout연습 - Views.FlexLayoutPage.xaml

참고: 
마소문서 https://learn.microsoft.com/ko-kr/dotnet/maui/user-interface/layouts/flexlayout?view=net-maui-7.0

![image](https://user-images.githubusercontent.com/68939699/229242599-b4bd2b3c-a02b-4b45-b4d1-b7b943286983.png)

```
<!--[아이템]: 4x2-->
<FlexLayout JustifyContent="SpaceAround" Wrap="Wrap" Margin="5"
            BindableLayout.ItemsSource="{Binding Items}">
    <BindableLayout.ItemTemplate>
        <DataTemplate>
            <VerticalStackLayout FlexLayout.AlignSelf="Center">
                <BoxView WidthRequest="70" HeightRequest="70" Color="Gray"/>
                <Label Text="{Binding}" HorizontalOptions="Center" Margin="0,5,0,5"></Label>
            </VerticalStackLayout>
        </DataTemplate>
    </BindableLayout.ItemTemplate>
</FlexLayout>
```
## 4. FinalPage - Views.FinalPage.xaml
기초연습 참고: 인프런 마우이 기초강좌 (깊알못)
https://github.com/kangsong77/MAUI_01_02_Inflearn

```
<ContentPage.Resources>
        <ResourceDictionary>
            <!-- 레이블 Font 16 -->
            <Style TargetType="Label">
                <Setter Property="FontSize" Value="16" />
            </Style>
            <!-- 버튼 -->
            <Style TargetType="Button">
                <Setter Property="FontSize" Value="16" />
                <Setter Property="Padding" Value="20" />
                <Setter Property="BackgroundColor" Value="#065BF5" />
                <Setter Property="CornerRadius" Value="0" />
            </Style>
            <!--특정 레이블에만 스타일 지정하기 위해 이름지정-->
            <Style TargetType="VerticalStackLayout" x:Key="verticalContent">
                <Setter Property="Spacing" Value="10" />
                <Setter Property="Padding" Value="20" />
                <Setter Property="BackgroundColor" Value="#FFF" />
            </Style>
        </ResourceDictionary>
    </ContentPage.Resources>
    <!-- 전체 : [스크롤뷰가 있는 content][확인버튼]-->
    <Grid RowDefinitions="*, auto" RowSpacing="10" >
        <!-- 스크롤뷰: 단일 자식만 가능 -->
        <ScrollView Grid.Row="0">
            <!--상단 3개 content :[고객정보][결제정보][기타정보]-->
            <VerticalStackLayout>
                <!-- [고객정보]: 텍스트5줄 -->
                <VerticalStackLayout Style="{StaticResource verticalContent}" >
                    <Label Text="내주소" FontAttributes="Bold"></Label>
                    <Label Text="서울 강남구 강남대로" ></Label>
                    <Label Text="396 강남역 지하 1층" ></Label>
                    <Label Text="반려동물" Margin="0,20,0,0" FontAttributes="Bold"></Label>
                    <Label Text="없음"></Label>
                </VerticalStackLayout>
                <!-- [결제정보]: 텍스트3줄 content-->
                <VerticalStackLayout Style="{StaticResource verticalContent}" >
                    <Label Text="결제정보" FontAttributes="Bold"></Label>
                    <Grid ColumnDefinitions="*,auto">
                        <Label Grid.Column="0" Text="결제 예정 금액"></Label>
                        <Label Grid.Column="1" Text="31,200원" ></Label>
                    </Grid>
                    <Label Grid.Row="2" Text="결제는 서비스가 완료된 후 진행됩니다."
                           TextColor="#A2A2A2"></Label>
                </VerticalStackLayout>
                <!-- [기타정보]: content4줄-->
                <VerticalStackLayout Style="{StaticResource verticalContent}" >
                    <Label Text="청소 도구를 꼭 준비해주세요." ></Label>
                    <!--[아이템]: 4x2-->
                    <FlexLayout JustifyContent="SpaceAround" Wrap="Wrap" Margin="5">
                        <BindableLayout.ItemsSource>
                            <x:Array Type="{x:Type x:String}">
                                <x:String>청소기</x:String>
                                <x:String>쓰레기봉투</x:String>
                                <x:String>수세미</x:String>
                                <x:String>욕실세제</x:String>
                                <x:String>밀대걸레</x:String>
                                <x:String>고무장갑</x:String>
                                <x:String>주방세제</x:String>
                                <x:String>걸레</x:String>
                            </x:Array>
                        </BindableLayout.ItemsSource>
                        <BindableLayout.ItemTemplate>
                            <DataTemplate>
                                <VerticalStackLayout FlexLayout.AlignSelf="Center">
                                    <BoxView WidthRequest="70" HeightRequest="70" Color="#E3E4E7"/>
                                    <Label Text="{Binding .}" HorizontalOptions="Center" Margin="0,5,0,5"></Label>
                                </VerticalStackLayout>
                            </DataTemplate>
                        </BindableLayout.ItemTemplate>
                    </FlexLayout>
                    <Label Text="취소/변경시 규정에 따라 수수료가 부과됩니다." ></Label>
                    <Label Text="수수료 규정 보기" 
                           TextColor="#065BF5" FontAttributes="Bold"></Label>
                </VerticalStackLayout>
            </VerticalStackLayout>
        </ScrollView>
        <Button Grid.Row="1" Text="홈으로" x:Name="OkBtn" Clicked="OkBtn_Clicked"></Button>
    </Grid>
```

