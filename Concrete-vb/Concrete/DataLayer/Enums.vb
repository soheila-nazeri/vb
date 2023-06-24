Public Class Enums


    ''' <summary>
    ''' نحوه قیمت گذاری
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum CostCalculationTypeN
        PriceList = 1
        Definite = 2
        PerPeople = 3
    End Enum

    Public Enum GoodTransferCause
        Repair = 1
        Sale = 2
        Corrupt = 3
        Change = 4
        Charge = 5
        Trust = 6
        Other = 7
    End Enum

    Public Enum CostRegisterPlace
        Formula = 1
        Contract = 2
        RegisterCard = 3
    End Enum

    Public Enum CostCenterType
        ''' <summary>
        '''نوع مرکز هزینه: 1-درآمد ، 2-مانده مسافر ، 3-قرارداد ، 4-پرسنل ، 5-پیش دریافت رزرو ، 6-صندوق ، 7-بانک
        ''' </summary>
        ''' <remarks></remarks>
        Income = 1
        GuestRemain = 2
        Reserve = 3
        Contract = 4
        Personel = 5
        Cash = 6
        Bank = 7
    End Enum

    ''' <summary>
    ''' Room: مانده مهمان
    ''' RoomCash: اتاقی نقدی
    ''' RoomContract: اتاقی بر حسب قرارداد
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum PayType
        Room = 2
        Contract = 4
        Personel = 5
        Cash = 6
        Bank = 7
        RoomCash = 8
        RoomContract = 9
    End Enum





    Public Class Codes

        ''' <summary>انواع وضعيت اتاقها</summary>
        Public Enum RoomStatus
            ''' <summary>خالي</summary>
            Free = 0
            ''' <summary>پر</summary>
            InUsed = 1
            ''' <summary>در حال سرويس</summary>
            Service = 2
            ''' <summary>در حال تعمير</summary>
            Repair = 3
            ''' <summary>بلوکه</summary>
            Lock = 4
            ''' <summary>رزرو</summary>
            Reserve = 5
            ''' <summary>اشغال موقت</summary>
            TempOccupancy = 6
            ''' <summary>Exitيهاي امروز</summary>
            TodayCheckout = 7
            ''' <summary>نظافت شده</summary>
            Cleaning = 8
            ''' <summary>غير فعال</summary>
            DeActive = -1
        End Enum

        ''' <summary>انواع قيمتهاي انواع اتاق</summary>
        Public Enum RoomPriceType
            ''' <summary>ايراني</summary>
            Iranian = 1
            ''' <summary>خارجي</summary>
            Foreign = 2
        End Enum

        ''' <summary>مبناي محاسبه قيمتها در شارژ</summary>
        Public Enum CostBasedType
            ''' <summary>اتاق</summary>
            Room = 1
            ''' <summary>نفر</summary>
            People = 2
        End Enum

        ''' <summary>مرجع قيمتها در شارژ</summary>
        Public Enum CostReferenceType
            ''' <summary>فهرست بها</summary>
            PriceList = 1
            ''' <summary>قيمت مشخص</summary>
            Definite = 2
        End Enum

        ''' <summary>نوع شارژ</summary>
        Public Enum ChargeType
            ''' <summary>خودکار</summary>
            Auto = 1
            ''' <summary>درصورت استفاده</summary>
            Consume = 2
        End Enum

        ''' <summary>نوع محدوديت در شارژ</summary>
        Public Enum ChargeLimitType
            ''' <summary>بدون محدوديت</summary>
            Infinite = 1
            ''' <summary>ظرفيت اتاق</summary>
            RoomOccupy = 2
            ''' <summary>تعداد مهمان</summary>
            GuestCount = 3
            ''' <summary>مقدارمشخص</summary>
            Definite = 4
        End Enum

        ''' <summary>بازه کنترل محدوديت</summary>
        Public Enum ChargeLimitDuration
            ''' <summary>بدون محدوديت</summary>
            Day = 1
            ''' <summary>مدت اقامت</summary>
            ResidentTime = 2
            ''' <summary>قرارداد</summary>
            Contract = 3
        End Enum

        ''' <summary>انواع شهرها</summary>
        Public Enum CityType
            ''' <summary>کشور</summary>
            Country = 1
            ''' <summary>استان</summary>
            Province = 2
            ''' <summary>شهر</summary>
            City = 3
            ''' <summary>گروه</summary>
            Group = 4
        End Enum

        ''' <summary>جنسيت</summary>
        Public Enum Gender
            ''' <summary>مرد</summary>
            Male = 1
            ''' <summary>زن</summary>
            Female = 2
        End Enum
        ''' <summary>وضعيتهاي رجيسترکارت</summary>
        Public Enum RegisterStatus
            ''' <summary>موقت</summary>
            Temporary = 0
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>تخليه شده</summary>
            Checkout = 2
            ''' <summary>تسويه</summary>
            PayOff = 3
            ''' <summary>ابطال</summary>
            Cancel = 9
        End Enum

        ''' <summary>وضعيتهاي اتاقهاي رجيسترکارت</summary>
        Public Enum RegisterRoomStatus
            ''' <summary>موقت</summary>
            Temporary = 0
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>تخليه شده</summary>
            Checkout = 2
            ''' <summary>تسويه</summary>
            PayOff = 3
            ''' <summary>تعويض شده</summary>
            Change = 4
            ''' <summary>تغيير نوع</summary>
            ChangeType = 5
            ''' <summary>ابطال</summary>
            Cancel = 9
        End Enum

        ''' <summary>وضعيتهاي اتاق مهمانان رجيسترکارت</summary>
        Public Enum RegisterRoomGuestStatus
            ''' <summary>موقت</summary>
            Temporary = 0
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>خارج شده</summary>
            Checkout = 2
            ''' <summary>تعويض شده</summary>
            Change = 3
            ''' <summary>تغيير نوع</summary>
            ChangeType = 4
            ''' <summary>ابطال</summary>
            Cancel = 9
        End Enum

        ''' <summary>وضعيتهاي مهمانان رجيسترکارت</summary>
        Public Enum RegisterGuestStatus
            ''' <summary>موقت</summary>
            Temporary = 0
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>خارج شده</summary>
            Checkout = 2
            ''' <summary>ابطال</summary>
            Cancel = 9
        End Enum

        ''' <summary>وضعيتها</summary>
        Public Enum Status
            ''' <summary>غيرفعال</summary>
            DeActive = 0
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>در حال گردش</summary>
            Flow = 2
            ''' <summary>پايان گردش</summary>
            EndProcess = 3
            ''' <summary>قطعي</summary>
            Definite = 4
            ''' <summary>ابطال</summary>
            Cancel = 9
            ''' <summary>بسته شده</summary>
            Closed = 5
            ''' <summary>موقت</summary>
            Temporary = 6
        End Enum

        ''' <summary>انواع مهمانان رجيستر</summary>
        Public Enum RegisterGuestType
            ''' <summary>عادي</summary>
            Normal = 2
            ''' <summary>اضافه تمام بها</summary>
            ExtraFull = 3
            ''' <summary>اضافه نيمه بها</summary>
            ExtraHalf = 4
            ''' <summary>زير سن محاسبه</summary>
            NotAccounting = 5
        End Enum

        ''' <summary>انواع شرکتها</summary>
        Public Enum ContractorType
            ''' <summary>مهمان</summary>
            Guest = 1
            ''' <summary>حقيقي</summary>
            Personal = 2
            ''' <summary>حقوقي</summary>
            Company = 3
            ''' <summary>فروشنده</summary>
            Seller = 4
            ''' <summary>مالک</summary>
            Owner = 5
            ''' <summary>پيمانکار</summary>
            Contractor = 6
        End Enum

        ''' <summary>نحوه پرداخت</summary>
        Public Enum PayType
            ''' <summary>نقدي</summary>
            Cash = 1
            ''' <summary>دستگاه Pos</summary>
            Pos = 2
            ''' <summary>فيش بانکي</summary>
            BankFish = 3
            ''' <summary>اتاق</summary>
            Room = 4
            ''' <summary>اتاق قراردادي</summary>
            RoomContract = 5
            ''' <summary>قرارداد</summary>
            Contract = 6
            ''' <summary>پرسنل</summary>
            Personel = 7
            ''' <summary>رايگان</summary>
            Free = 8
            ''' <summary>نقد+Pos</summary>
            PosCash = 9
            ''' <summary>اينترنتي</summary>
            Enternet = 10
            ''' <summary>رزرو</summary>
            Reserve = 11
            ''' <summary>هزينه</summary>
            Cost = 12
            ''' <summary>چک</summary>
            CHEQUES = 13
        End Enum

        ''' <summary>نوع سرويس رستوران</summary>
        Public Enum FoodServiceType
            ''' <summary>محل</summary>
            Local = 1
            ''' <summary>اتاق</summary>
            RoomService = 2
            ''' <summary>ساير</summary>
            Other = 3
            ''' <summary>بيرون بر</summary>
            Export = 4
            ''' <summary>سرويس VIP</summary>
            VIP = 5
            ''' <summary>مراسم</summary>
            ceremony = 6
            ''' <summary>سرويس متفرقه</summary>
            EtcService = 7
        End Enum

        ''' <summary>وضعيت صورتحسابها</summary>
        Public Enum BillStatus
            ''' <summary>باز</summary>
            Temporary = 0
            ''' <summary>بسته</summary>
            Definite = 1
            ''' <summary>ابطال</summary>
            Cancel = 9
        End Enum

        ''' <summary>انواع سرويس ها</summary>
        Public Enum ServiceType
            ''' <summary>غذاها</summary>
            Food = 1
            ''' <summary>سرويس</summary>
            Service = 2
            ''' <summary>لباس</summary>
            Landry = 3
            ''' <summary>کالاي فروشگاه</summary>
            ShopGood = 4
            ''' <summary>ملزومات اتاق</summary>
            RoomSupplies = 5
            ''' <summary>خسارت</summary>
            Damage = 6
            ''' <summary>انواع خدمات</summary>
            ServiceType = 7
        End Enum

        ''' <summary>انواع خصوصيات رجيستر</summary>
        Public Enum RegisterPropertyType
            ''' <summary>قرارداد</summary>
            Contract = 1
            ''' <summary>پيغام</summary>
            Message = 2
            ''' <summary>يادداشت</summary>
            Notification = 3
            ''' <summary>شارژاتاق</summary>
            RoomCharge = 4
            ''' <summary>سوابق مدت اقامت</summary>
            ResidentTimeHistory = 5
            ''' <summary>نوع Vip</summary>
            VipType = 6
            ''' <summary>شماره چاپ صورتحساب رجيستر</summary>
            BillPrintNo = 7
            ''' <summary>اضافه شارژ اتاق</summary>
            DailyUse = 8
            ''' <summary>استفاده از قرار داد گارانتي</summary>
            UseFromGuaranteeContract = 9
            ''' <summary>شماره سريال صورتحساب فروش</summary>
            SerialNoSaleBill = 10
            ''' <summary>معرف</summary>
            Presenter = 11
        End Enum

        ''' <summary>انواع خصوصيات افراد</summary>
        Public Enum PeoplePropertyType
            ''' <summary>پرسنل</summary>
            Personel = 1
            ''' <summary>معرف</summary>
            Presenter = 2
            ''' <summary>واحد رزرو</summary>
            ReserveUnit = 3
            ''' <summary>پشتيبان</summary>
            Supporter = 4
            ''' <summary>ليست سياه</summary>
            BlackList = 5
            ''' <summary>ميزبان</summary>
            Host = 6
            ''' <summary>راننده</summary>
            Driver = 7
            ''' <summary>تخفيف پرسنل</summary>
            PersonelDiscount = 8
            ''' <summary>مامور خريد</summary>
            PurchasingOfficer = 9
            ''' <summary>کد مالي پرسنل</summary>
            AccountCode = 10
            ''' <summary>کدينگ مالي مامور خريد</summary>
            AccCodePurchasingOfficer = 11
            ''' <summary>کفالت احکام</summary>
            AgreementBail = 12
            ''' <summary>کفالت درمان</summary>
            TreatmentBail = 2
            ''' <summary>ثبات</summary>
            Registrar = 14
        End Enum

        ''' <summary>تنظيمات</summary>
        Public Enum Setting
            ''' <summary>تنظيمات شارژ</summary>
            ChargeSetting = 25
            ''' <summary>تنظيمات رک</summary>
            RackSetting = 25
            ''' <summary>تنظيمات رستوران</summary>
            RestaurantSetting = 25
            ''' <summary>تنظيمات تريا</summary>
            TeriaSetting = 25
            ''' <summary>تنظيمات رجيستر کارت</summary>
            RegisterSetting = 29
            ''' <summary>تنظيمات مشترکين</summary>
            SubscribSetting = 30
            ''' <summary>ساير تنظيمات</summary>
            OtherSetting = 32
            ''' <summary>تنظيمات صورتحساب</summary>
            GustBillSetting = 33
            ''' <summary>تنضيمات رزرو</summary>
            ReserveSetting = 34
            ''' <summary>تنظيمات پيامک</summary>
            SmsSetting = 3
            ''' <summary>تنظيمات کد حساب سند حسابداري</summary>
            AccountCodeSetting = 37
            ''' <summary>تنظيمات لاندري</summary>
            LandrySetting = 38
            ''' <summary>تنظيمات ايميل</summary>
            EmailSetting = 39
            ''' <summary>تنظيمات فروشگاه</summary>
            ShopSetting = 40
            ''' <summary>تنظيمات خانه داري</summary>
            RoomKeepingSetting = 42
            ''' <summary>تنظيمات رزرو خدمات</summary>
            ServiceReserveSetting = 42
            ''' <summary>تنظيمات پيام صوتي</summary>
            AudioMessageSetting = 45
            ''' <summary>تنظيمات انبار و کاست کنترل</summary>
            StoreAndCostControlSetting = 46
            ''' <summary>تنظيمات PC POS</summary>
            PcPosSetting = 47
            ''' <summary>تنظيمات اسپا سنتر</summary>
            SpaSetting = 2
        End Enum

        ''' <summary>تنظيمات شارژ</summary>
        Public Enum ChargeSetting
            ''' <summary>انواع شب رايگان</summary>
            FreeDayType = 18
            ''' <summary>ساعت شارژ</summary>
            ChargeTime = 1
            ''' <summary>ساعت شارژ شب قبل</summary>
            LastNightChargeTime = 2
            ''' <summary>ساعت اضافه شارژ اول</summary>
            DailyUseTimeFirst = 3
            ''' <summary>ساعت اضافه شارژ دوم</summary>
            DailyUseTimeSecond = 4
            ''' <summary>درصد اضافه شارژ اول</summary>
            DailyUsePercentFirst = 5
            ''' <summary>درصد اضافه شارژ دوم</summary>
            DailyUsePercentSecond = 6
            ''' <summary>حدقل سن محاسبه</summary>
            AccountingAge = 7
            ''' <summary>سن محاسبه نيمه بها</summary>
            HalfAccountingAge = 8
            ''' <summary>محاسبه اضافه شارژ بر اساس فهرست بها</summary>
            DailyUseByPriceList = 9
            ''' <summary>شارژ گارانتي</summary>
            GuaranteeCharge = 10
            ''' <summary>شارژ مانده گارانتي</summary>
            ChargeRemainGuarantee = 11
            ''' <summary>شارژ صبحانه بر مبناي ظرفيت اتاق</summary>
            ChargeBasedRoomCapacity = 12
            ''' <summary>محاسبه تخفيف صبحانه شارژ</summary>
            ComputeBreakfastDiscount = 13
            ''' <summary>ساعت اضافه شارژ اول مشترکين</summary>
            DailyUseTimeFirstSubscribe = 14
            ''' <summary>ساعت اضافه شارژ دوم مشترکين</summary>
            DailyUseTimeSecondSubscribe = 15
            ''' <summary>محاسبات براساس پکيج</summary>
            PackageCalculating = 16
            ''' <summary>فعال سازي جريمه Exit زود هنگام</summary>
            ActiveRoomChargeExitEarly = 17
            ''' <summary>اعمال شارژ شب قبل به روز گذشته</summary>
            LastNightChargePreDate = 18
            ''' <summary>درصد شارژ ورود زود هنگام</summary>
            EarlyArrivalChargePercent = 19
            ''' <summary>ساعت شروع پذيرش</summary>
            ReceptionStartTime = 20
            ''' <summary>فعال سازي شارژ تاخير در ورود</summary>
            ActiveRoomChargeArrivalDelay = 21
        End Enum

        ''' <summary>تنظيمات رک</summary>
        Public Enum RackSetting
            ''' <summary>نمايش Header در رک</summary>
            RackHeader = 1
            ''' <summary>غير فعال نشدن رک</summary>
            NotDisable = 2
        End Enum

        ''' <summary>تنظيمات رستوران</summary>
        Public Enum RestaurantSetting
            ''' <summary>جاپ برگه آشپزخانه رستوران پس از ثبت صورتحساب</summary>
            KitchenPrint = 1
            ''' <summary>سوال کردن جهت جاپ برگه آشپزخانه رستوران پس از ثبت صورتحساب</summary>
            QuestionForPrint = 2
            ''' <summary>جاپ برگه سرويس اتاق پس از ثبت صورتحساب</summary>
            ServicePrint = 3
            ''' <summary>چاپ دسر خوري</summary>
            DesertPrint = 4
            ''' <summary>درصد سرويس اتاق</summary>
            RoomServicePercent = 5
            ''' <summary>چاپ برگه حسابداري رستوران</summary>
            FinancialPrint = 6
            ''' <summary>چاپ برگه مشتري</summary>
            IsPrintCustomerCash = 7
            ''' <summary>نوع برگه صندوق</summary>
            CashPageType = 8
            ''' <summary>درصد سرويس محل</summary>
            LocalServicePercent = 9
            ''' <summary>درصد ساير سرويسها</summary>
            OtherServicePercent = 10
            ''' <summary>عدم محاسبه ماليات رستوران</summary>
            NotDuty = 11
            ''' <summary>درصد سرويس بيرون بر</summary>
            ExportServicePercent = 12
            ''' <summary>رستوران بن هاي نهار و شام ثبت شده در صندوق</summary>
            LunchResturantDefualt = 13
            ''' <summary>رستوران بن هاي صبحانه ثبت شده در صندوق</summary>
            BerekResturantDefualt = 14
            ''' <summary>صدور بن بر اساس منوي غذاي</summary>
            HasFoodMenu = 15
            ''' <summary>پيغام زير صورتحساب رستوران </summary>
            ResturantBillFooterMessage = 16
            ''' <summary>چاپ برگه صندوق</summary>
            ResturantBillPrint = 17
            ''' <summary>تعداد چاپ برگه صندوق</summary>
            ResturantBillPrintCount = 18
            ''' <summary>جاپ برگه آشپزخانه گروههاي غذاي غير اصلي</summary>
            KitchenPrintForNotMain = 19
            ''' <summary>درصد سرويس مراسم</summary>
            ceremony = 20
            ''' <summary>درصد سرويس Vip</summary>
            VIP = 21
            ''' <summary>استفاده از حق سرويس در رستوران جديد</summary>
            UseServiceInNewResturant = 22
            ''' <summary>استفاده از ماليت  در رستوران جديد</summary>
            UseDutyInNewResturant = 23
            ''' <summary>فعال بودن تخفيف در رستوران جديد</summary>
            EnableDiscountInNewResturant = 24
            ''' <summary>تخفيف تمام آيتمهاي فاکتور رستوران</summary>
            DisForAllItemInFactorResturant = 25
            ''' <summary>عدم چاپ رمز اينترنت</summary>
            DontPrintPasswordOfInternetRestaurant = 26
            ''' <summary>امکان بستن بن با صندوق روز گذشته</summary>
            DefiniteBillByYesterdayShift = 27
            ''' <summary>نمايش مبلغ در برگه آشپزخانه</summary>
            ShowPriceKitchenPrint = 28
            ''' <summary>عدم چاپ بن پرسنلي</summary>
            NotPrintPersonelBill = 29
        End Enum

        ''' <summary>تنظيمات تريا</summary>
        Public Enum TeriaSetting
            ''' <summary>جاپ برگه آشپزخانه تريا پس از ثبت صورتحساب</summary>
            KitchenPrint = 1
            ''' <summary>سوال کردن جهت جاپ برگه آشپزخانه تريا پس از ثبت صورتحساب</summary>
            QuestionForPrint = 2
            ''' <summary>چاپ برگه حسابداري تريا</summary>
            FinancialPrint = 3
            ''' <summary>چاپ برگه مشتري</summary>
            IsPrintCustomerCash = 4
            ''' <summary>نوع برگه صندوق</summary>
            CashPageType = 5
            ''' <summary>عدم محاسبه ماليات تريا</summary>
            NotDuty = 6
            ''' <summary>پيغام زير صورتحساب تريا </summary>
            TeriaBillFooterMessage = 7
            ''' <summary>چاپ برگه صندوق</summary>
            TeriaBillPrint = 8
            ''' <summary>تعداد چاپ برگه صندوق</summary>
            TeriaBillPrintCount = 9
            ''' <summary>عدم چاپ رمز اينترنت</summary>
            DontPrintPasswordOfInternetTeria = 10
        End Enum

        ''' <summary>تنظيمات رجيستر کارت</summary>
        Public Enum RegisterSetting
            ''' <summary>ضريب درآمد</summary>
            IncomePersent = 3
            ''' <summary>ارسال پيامک بعداز ثبت رجيستر</summary>
            SmsSend = 2
            ''' <summary>ارسال پيامک Exit مهمان</summary>
            TodayExitGuest = 4
            ''' <summary>ارسال پيامک تسويه اتاق </summary>
            PayOffSendSMS = 5
            ''' <summary>عدم اجباري بودن کد ملي</summary>
            NotForceNationalCode = 6
            ''' <summary>اعمال تاريخ پايان قرارداد</summary>
            UseEndDateOfContract = 7
            ''' <summary>عدم نمايش توضيحات رزرودر چاپ موقت رجيسترکارت</summary>
            DontShowDescriptionOfReserveInTemporaryRegisterPrint = 8
            ''' <summary>عدم نمايش قرارداد به صورت پيش فرض</summary>
            HideContractDefault = 8
            ''' <summary>پيام چاپ رجيستر موقت</summary>
            MessageOfTemperoryRegister = 10
            ''' <summary>پيام لاتين چاپ رجيستر موقت</summary>
            EnglishMessageOfTemperoryRegister = 11
        End Enum

        ''' <summary>تنظيمات مشترکين</summary>
        Public Enum SubscribSetting
            ''' <summary>مبلغ هر امتياز</summary>
            PrivilegePrice = 1
            ''' <summary>ارزش هر امتياز جهت تخفيف</summary>
            PrivilegePriceForDiscount = 3
            ''' <summary>درصد مجاز تخفيف امتياز مشترک</summary>
            DiscountPercentForResident = 4
            ''' <summary>امکان تغيير کد اشتراک</summary>
            AllowChangeCode = 5
            ''' <summary>اجباري کردن کد ملي مشترکين</summary>
            ForceNationalCode = 2
            ''' <summary>برگشت اضافه شارژ مشترکين</summary>
            ReturnDailyUseSubscribe = 8
            ''' <summary>ايجاد مشترک پس از ثبت رجيستر کارت</summary>
            CreateSubscribeInRegister = 9
            ''' <summary>اولويت پيش فرض مشترکين شخصي</summary>
            DefaultPriority = 10
            ''' <summary>ارسال پيامک بعداز ثبت</summary>
            SMSSEND = 1
            ''' <summary>ارسال پيامک امتياز مشترکين</summary>
            SendSmsSubscribePrivilege = 12
            ''' <summary>نمايش مبلغ در پبامک امتياز مشترکين</summary>
            ShowPrivilegePriceInSMS = 13
            ''' <summary>اولويت پيش فرض مشترکين شرکتي</summary>
            DefaultPriorityContractor = 14
            ''' <summary>اولويت پيش فرض مشترکين آژانسي</summary>
            DefaultPriorityAgency = 15
            ''' <summary>ايجاد مشترک پس از ثبت شرکت</summary>
            CreateSubscribeInContractor = 16
            ''' <summary>استفاده از امتياز براي کل هزينه ها</summary>
            UseAllCostForPrivilegeDiscount = 17
            ''' <summary>امکان استفاده مشترکين از اعتبارهاي هديه در خدمات غير اقامتي</summary>
            UsingScoreInNoneResident = 18
        End Enum

        ''' <summary>ساير تنظيمات</summary>
        Public Enum OtherSetting
            ''' <summary>هزينه اينترنت</summary>
            InternetPrice = 1
            ''' <summary>محاسبه ماليات بعداز کسر تخفيف</summary>
            DutyAfterDiscount = 2
            ''' <summary>ضريب درآمد</summary>
            IncomePersent = 3
            ''' <summary>ضريب ماليات</summary>
            DutyPersent = 4
            ''' <summary>آدرس سايت اماکن</summary>
            AmakenWebSite = 5
            ''' <summary>مبلغ گرد کردن ماليات</summary>
            DutyRoundPrice = 6
            ''' <summary>نسبت عوارض به ماليات </summary>
            TaxDutyPercent = 7
            ''' <summary>عدم محاسبه ماليات بن پرسنلي</summary>
            NotDutyForPersonel = 8
            ''' <summary>چاپ متمرکز صورتحسابها</summary>
            CenteralBillPrint = 9
            ''' <summary>مديريت فيش هاي بانکي</summary>
            ManagePosBank = 10
            ''' <summary>تخليه خودکار حافطه</summary>
            RefereshMain = 11
            ''' <summary>سقف معافيت مالياتي</summary>
            DeductibilityCeiling = 12
            ''' <summary>آدرس داشبورد مديريتي</summary>
            ManagementDashboardAddress = 13
            ''' <summary>شناسه ي مهمانان اعتباري</summary>
            GuestContractorID = 19
            ''' <summary>کد انبار براي انتقال مصرف مستقيم</summary>
            CodeOfStoreForDirectConsumption = 11
            ''' <summary>آدرس وب سرويس پاسپورت اسکنر</summary>
            PassportScannerWebserviceUrl = 20
            ''' <summary>شناسه ي فهرست بهاي هزينه</summary>
            CostPriceListId = 14
            ''' <summary>شناسه ي فهرست بهاي پرسنل</summary>
            PersonelPriceListId = 15
            ''' <summary>فعال بودن سقف مجاز دسترسي به داده هاي راکد</summary>
            EnableArchiveDayLong = 16
            ''' <summary>عدم محاسبه ماليات بن هزينه</summary>
            NotDutyForCostBill = 17
            ''' <summary>کنترل اتاقهاي تخليه شده هنگام واريز به بانک</summary>
            ControlOfCheckoutRoomsDepositToTheBank = 18
            ''' <summary>کنترل بن هاي باز اتاقي هنگام واريز به بانک</summary>
            ControlOpenBillsDepositToTheBank = 19
            ''' <summary>امکان تغيير در آيتم هاي صورتحساب</summary>
            EditBillItems = 20
        End Enum

        ''' <summary>تنظيمات صورتحساب</summary>
        Public Enum GustBillSetting
            ''' <summary>نمايش همراهان در صورتحساب مهمان</summary>
            ShowCompanionInBilling = 1
            ''' <summary>پيغام زير صورتحساب مهمان - فارسي</summary>
            GustBillFooterMessageFarsi = 2
            ''' <summary>پيغام زير صورتحساب مهمان - لاتين</summary>
            GustBillFooterMessageLatin = 3
            ''' <summary>نمايش هزينه اقامت پس از کسر تخفيف</summary>
            ShowRoomCostByDiscount = 4
            ''' <summary>پيغام جهت کنترل سقف بدهکاري مهمان و شرکتها</summary>
            ShowMessagePriceRoof = 5
            ''' <summary>کنترل سقف بدهکاري مهمان و شرکتها</summary>
            CreditControlByPriceRoof = 6
            ''' <summary>نمايش سرجمع در صورتحساب</summary>
            ShowSumCost = 7
            ''' <summary>تفکيک نفر اضافه در صورتحساب</summary>
            NotSeparateExtraCost = 8
            ''' <summary>تفکيک صبحانه شارژ در صورتحساب</summary>
            NotSeparateBreakfastCost = 9
            ''' <summary>فعال بودن چاپ غير رسمي در صورتحساب</summary>
            EnablePrintWithoutHotelInfo = 10
            ''' <summary>چاپ 2 به عنوان چاپ پيش فرض</summary>
            IsDefualtPrintWithoutHotelInfo = 11
            ''' <summary>نمايش هزينه اقامت با احتساب ماليات</summary>
            ShowRoomCostByDuty = 12
            ''' <summary>نمايش اضافه شارژ پيش فرض در صورتحساب </summary>
            ShowVirtualDailyUseInBill = 13
            ''' <summary>نمايش اتاق در چاپ صورتحساب مهمان</summary>
            ShowRoomNoBillPrint = 14
            ''' <summary>پيغام امتياز مشترک زير صورتحساب مهمان</summary>
            SubscribePrivelageInGustBillMsg = 15
            ''' <summary>اجباري کردن بستن ميني بار در تخليه اتاق</summary>
            ForceCloseMinibarInCheckout = 16
            ''' <summary>(A5) برگه پيش فرض  صورتحساب</summary>
            IsDefualtPrintA5 = 17
            ''' <summary>استفاده از ارز</summary>
            UseCurrency = 18
            ''' <summary>نمايش محاسبه غذاهاي فولبرد</summary>
            ShowComputeFullBoard = 19
            ''' <summary>تفکيک ستون تخفيف در چاپ صورتحساب</summary>
            SeparateDiscountBillPrint = 20
            ''' <summary>مسير فايل الکترونيکي صورتحساب</summary>
            BillPrintPdfPath = 21
            ''' <summary>آدرس وب سرور فايل الکترونيکي صورتحساب</summary>
            BillPrintPdfServicePath = 22
            ''' <summary>ثبت توضيحات در زمان تخليه</summary>
            RegisterDescriptionCheckOut = 23
        End Enum

        ''' <summary>تنضيمات رزرو</summary>
        Public Enum ReserveSetting
            ''' <summary>فعال کردن تشخيص رزروهاي سفارشي</summary>
            EnableOfficialReservation = 17
            ''' <summary>پيغام زير رزرو - فارسي</summary>
            ReserveFooterMessageFarsi = 1
            ''' <summary>پيغام زير رزرو - لاتين</summary>
            ReserveFooterMessageLatin = 2
            ''' <summary>ارسال پيامک بعداز ثبت رزرو</summary>
            SmsSend = 3
            ''' <summary>منفي شدن رزرو</summary>
            ReserveOver = 4
            ''' <summary>غير فعال کردن رزرو اينترنتي</summary>
            DisableInternetReserve = 5
            ''' <summary>زمان کنسلي روز قبل جهت جريمه يک شب اقامت</summary>
            ReserveCancelTimeForPenalty = 6
            ''' <summary>درصد جريمه کنسلي رزرو</summary>
            ReserveCancelPenaltyPercent = 7
            ''' <summary>کنترل سقف بدهکاري شرکتها در رزرو</summary>
            CreditControlContractInReserve = 8
            ''' <summary>ارسال ايميل بعد از ثبت رزرو</summary>
            EmailSend = 9
            ''' <summary>اعمال تخفيف اينترنتي</summary>
            InternetDiscount = 2
            ''' <summary>محاسبه ماليات بعد از کسر کارمزد</summary>
            DutyAfterKarmozd = 10
            ''' <summary>قوانين تاييديه رزرو</summary>
            ConfirmationReserveRules = 11
            ''' <summary>قوانين تاييديه رزرو لاتين</summary>
            ConfirmationReserveLatinRules = 12
            ''' <summary>قطعي کردن رزروهاي اينترنتي</summary>
            DefinitInternetReserve = 13
            ''' <summary>محاسبه کارمزد پلکاني رزرو</summary>
            CalculateStairWage = 14
            ''' <summary>عدم نمايش کارمزدآژانس</summary>
            DontShowWageAgency = 15
            ''' <summary>کسر اتاقهاي تحت تعمير در آناليز</summary>
            DecrementRepairRoomInAnalize = 16
            ''' <summary>کارمزد بعد از افزودن ماليات</summary>
            KarmozdByDuty = 17
            ''' <summary>غيرفعال شدن اطلاعات سفر در بالاي برگه رزرو</summary>
            DontActiveInfoTravelInAboveReserveCard = 18
            ''' <summary>کنترل بلاک روز رزرو اينترنتي در طول مدت اقامت</summary>
            CheckDayBlockingInStayDuration = 19
            ''' <summary>عدم کنترل مانده رزرو هنگام کم کردن تعداداتاق يا مدت اقامت</summary>
            DontControlRemainReserveInReduceCountOfRoomOrInhabit = 20
            ''' <summary>عدم ثبت ضمائم بعد از Exit مهمان </summary>
            UnRegisteredAttachmentsAfterGuestExit = 21
            ''' <summary>تفکيک ماليات در چاپ تاييديه رزرو</summary>
            TaxSegregationInReserveVerify = 22
            ''' <summary>ارسال پيامک کنسلي موقت </summary>
            SendSmsTemporaryCancel = 23
            ''' <summary>ارسال پيامک کنسلي قطعي</summary>
            SendSmsDefiniteCancel = 24
            ''' <summary>منفي شدن رزرو از رجيستر</summary>
            ReserveOverByRegister = 25
            ''' <summary>مهلت پرداخت رزرو(دقيقه)</summary>
            DeadLineReservePayLink = 26
        End Enum

        ''' <summary>تنظيمات پيامک</summary>
        Public Enum SmsSetting
            ''' <summary>نام کاربري</summary>
            UserName = 1
            ''' <summary>رمز عبور</summary>
            Password = 2
            ''' <summary>شماره خط</summary>
            LineNumber = 3
            ''' <summary>ارسال پيام اوقات شرعي</summary>
            SendPrayerTime = 4
            ''' <summary>ارسال پيام تولد مشترکين</summary>
            SendHappyBirthdaySubscrib = 5
            ''' <summary>ارسال پيام تولد مهمانان مقيم</summary>
            SendHappyBirthdayResidentGuest = 6
            ''' <summary>ارسال پيام تولد کل مهمانان </summary>
            SendHappyBirthdayAllGuest = 7
            ''' <summary>ارسال پيامک اينترنت رستوران</summary>
            SendResturantInternet = 8
            ''' <summary>مبناي تاريخ ورود مهمانان براي پيامک تولد</summary>
            StartChekinDateAllGuest = 9
            ''' <summary>ارسال پيامک اينترنت اتاق</summary>
            SendRoomInternet = 10
            ''' <summary>ارائه دهنده سرويس پيامک </summary>
            SmsWebService = 11
            ''' <summary>ارسال پيام تبريک تولد پرسنل</summary>
            SendHappyBirthdayPersonel = 12
            ''' <summary>ارسال پيام تبريک ازدواج</summary>
            SendHappyMarriage = 13
            ''' <summary>پيامک وضعيت اشغالي اتاق مالک</summary>
            SendOwnerInOutRoom = 14
            ''' <summary>ارسال پيام تبليغاتي کل مهمانان</summary>
            SendAdvertisingMSGAllGuest = 15
        End Enum

        ''' <summary>تنظيمات کد حساب سند حسابداري</summary>
        Public Enum AccountCodeSetting
            ''' <summary>کد حساب  مانده مسافر</summary>
            GuestRemain = 1
            ''' <summary>کد حساب پرداخت نقدي</summary>
            Cash = 2
            ''' <summary>کد حساب رزرو </summary>
            Reserve = 3
            ''' <summary>کد حساب پرسنلي</summary>
            Personel = 4
            ''' <summary>کد پيش فرض حساب بانک-فيش بانکي</summary>
            DefualtBankAccountCode = 5
            ''' <summary>کد حساب عوارض</summary>
            TaxAccount = 6
            ''' <summary>ديتابيس فعال حسابداري</summary>
            AccountingSysActiveDataBase = 7
            ''' <summary>سرور و نام کاربري ديتابيس حسابداري</summary>
            AccountingSysDataBaseIp = 8
            ''' <summary>کد پيش فرض حساب بانک-دستگاه POS</summary>
            DefualtBankAccountCodePos = 9
            ''' <summary>کد پيش فرض حساب بانک-نقدي</summary>
            DefualtBankAccountCodeCash = 10
            ''' <summary> کل و معين حسابهاي دريافتني</summary>
            ReceivedAccountCode = 11
            ''' <summary>نمايش کاربر و زمان ايجاد و ويرايش سندهاي حسابداري</summary>
            ShowUserAndDate = 12
            ''' <summary>Delete سطراول فايل اکسل سند</summary>
            RemoveFirstLineExcel = 13
            ''' <summary>استفاده از نسخه جديد نرم افزار حسابداري</summary>
            UsingNewVersionAccountingSoftware = 14
            ''' <summary>پيشنهاد کد کل کدينگ حسابداري</summary>
            SuggestionAccountLevels1 = 15
            ''' <summary>کد واسط براي صدور سند</summary>
            AccInterfaces = 16
            ''' <summary>کدينگهاي واسط براي چک - حداقل سه سطحي</summary>
            ChequeMinLevel = 17
            ''' <summary>شرح رديف بدهکار براي سيستم خزانه داري</summary>
            DebitChequesDescription = 18
            ''' <summary>شرح رديف بستانکار براي سيستم خزانه داري</summary>
            CreditChequesDescription = 19
            ''' <summary>نمايش تمامي وضعيت اسناد</summary>
            ShowAllVoucherStatus = 20
            ''' <summary>شناسايي جدول تفضيلي - پرسنلي </summary>
            AccountTablePersonnel = 21
            ''' <summary>مرتب سازي سند به صورت صعودي</summary>
            SortVouchers = 22
            ''' <summary>نمايش تمام سالهاي مالي</summary>
            ShowAllFinance = 23
            ''' <summary>تفکيک اطلاعات فيزيکي و ريالي اسناد انبار</summary>
            SeparationOfPhysicalAndRialInformationOfDocuments = 24
        End Enum

        ''' <summary>تنظيمات لاندري</summary>
        Public Enum LandrySetting
            ''' <summary>درصد اضافه فاکتورهاي فوري</summary>
            FastBillPersent = 1
            ''' <summary>نوع برگه صندوق (A6=1)</summary>
            CashPageType = 2
            ''' <summary>عدم محاسبه ماليات لاندري</summary>
            NotDuty = 3
        End Enum

        ''' <summary>تنظيمات ايميل</summary>
        Public Enum EmailSetting
            ''' <summary>SMTP</summary>
            SMTP = 1
            ''' <summary>Port</summary>
            Port = 2
            ''' <summary>UserName</summary>
            UserName = 3
            ''' <summary>Password</summary>
            Password = 4
            ''' <summary>ارسال ايميل بعد از تسويه رجيستر</summary>
            EmailSendAfterPayOff = 5
            ''' <summary>مسير فايل تصويري ايميل</summary>
            EmailPicAttachmentPath = 6
            ''' <summary>ارسال ايميل تولد مهمانان مقيم</summary>
            EmailSendBirthdayResidentGuest = 7
            ''' <summary>مسير فايل تصويري ايميل تولد</summary>
            EmailPicBirthdayAttachmentPath = 8
            ''' <summary>ارسال ايميل تاييديه رزرو</summary>
            EmailSendAfterConfirmReserve = 9
            ''' <summary>مسير فايل تصويري ايميل تاييديه رزرو</summary>
            EmailPicConfirmReserveAttachmentPath = 10
            ''' <summary>ارسال ايميل تولد کل مهمانان</summary>
            EmailSendBirthdayAllGuest = 7
            ''' <summary>سرور نظر سنجي</summary>
            ServerPoll = 11
            ''' <summary>پورت سرور نظر سنجي</summary>
            PortPoll = 11
        End Enum

        ''' <summary>تنظيمات فروشگاه</summary>
        Public Enum ShopSetting
            ''' <summary>نوع برگه صندوق (A6=1)</summary>
            CashPageType = 1
            ''' <summary>عدم محاسبه ماليات فروشگاه</summary>
            NotDuty = 2
            ''' <summary>اجباري کردن کد ميزبان</summary>
            ForceHost = 3
        End Enum

        ''' <summary>تنظيمات خانه داري</summary>
        Public Enum RoomKeepingSetting
            ''' <summary>عدم محاسبه ماليات ميني بار</summary>
            NotDuty = 1
            ''' <summary>وضعيت نظافت شده</summary>
            CleaningStatus = 2
            ''' <summary>درصد حق سرويس</summary>
            ServicePercent = 3
            ''' <summary>چاپ برگه ملزومات پس از ثبت صورتحساب</summary>
            SuppliesPrint = 4
            ''' <summary>استفاده از اعلام چک اوت</summary>
            UseAnnounceCheckOut = 5
            ''' <summary>حداکثر زمان (ساعت) DND</summary>
            MaximumDNDTime = 6
            ''' <summary>قطعي کردن بن خسارت از طريق تبلت</summary>
            DetermineTheDamageBillByTablet = 7
        End Enum

        ''' <summary>تنظيمات رزرو خدمات</summary>
        Public Enum ServiceReserveSetting
            ''' <summary>ارسال پيامک بعداز ثبت رزرو</summary>
            SmsSend = 1
            ''' <summary>ارسال ايميل بعداز ثبت رزرو</summary>
            EmailSend = 2
        End Enum

        ''' <summary>اعلام چک اوت</summary>
        Public Enum AnnounceCheckOut
            ''' <summary>ثبت اعلام چک اوت</summary>
            InsertAnnounceCheckOut = 1
            ''' <summary>پايان اعلام چک اوت</summary>
            EndAnnounceCheckOut = 2
            ''' <summary>لغو اعلام چک اوت</summary>
            CancelAnnounceCheckOut = 3
        End Enum

        ''' <summary>انواع مشخصه هاي اتاق</summary>
        Public Enum RoomPropertyType
            ''' <summary>وضعيت</summary>
            Status = 1
            ''' <summary>امکانات اتاق</summary>
            Facilities = 2
            ''' <summary>تعداد اتاق بلاک شده</summary>
            ReserveRoomBlocked = 3
            ''' <summary>تعداد اتاق بلاک شده روز</summary>
            ReserveRoomDailyBlocked = 4
            ''' <summary>تعداد اتاق بلاک شده اينترنتي</summary>
            ReserveRoomInternetBlocked = 5
            ''' <summary>اطلاعات خانه داري</summary>
            RoomInfo = 6
            ''' <summary>پيغام اتاق</summary>
            RoomMessage = 7
            ''' <summary>مالک</summary>
            Owner = 8
            ''' <summary>قابل واگذاري</summary>
            Available = 9
            ''' <summary>اولويت سرويس</summary>
            ServicePriorty = 10
            ''' <summary>اعلام چک اوت</summary>
            AnnounceCheckOut = 11
            ''' <summary>بلاک اينترنتي ساير فروشندگان</summary>
            ReserveRoomOtherInternetBlocked = 12
        End Enum

        ''' <summary>مراکز هزينه مشخص</summary>
        Public Enum CostCenterItems
            ''' <summary>هزينه اقامت</summary>
            ResidentCost = 1
            ''' <summary>صبحانه</summary>
            Breakfast = 2
            ''' <summary>ناهار</summary>
            Lunch = 3
            ''' <summary>شام</summary>
            Dinner = 4
            ''' <summary>کافي شاپ</summary>
            Teria = 5
            ''' <summary>ميني بار</summary>
            Minibar = 6
            ''' <summary>تلفن</summary>
            Telephone = 7
            ''' <summary>پارکينگ</summary>
            Parking = 8
            ''' <summary>کنسلي رزرو</summary>
            ReserveCancel = 9
            ''' <summary>کارمزد رزرو</summary>
            ReserveJourneyWork = 10
            ''' <summary>عوارض</summary>
            Duty = 11
            ''' <summary>تخفيف</summary>
            Discount = 12
            ''' <summary>پيش دريافت</summary>
            PrePay = 13
            ''' <summary>تسويه حساب اتاق</summary>
            RoomPayoff = 14
            ''' <summary>علي الحساب</summary>
            TemporaryCash = 15
            ''' <summary>پرداخت رزرو</summary>
            ReservePayment = 16
            ''' <summary>پرداخت قرارداد</summary>
            ContractPayment = 17
            ''' <summary>انتقال صندوق</summary>
            CashTransfer = 18
            ''' <summary>بانک</summary>
            Bank = 19
            ''' <summary>تعهد قرارداد</summary>
            ContractGuarantee = 20
            ''' <summary>هزينه سرويس</summary>
            Service = 21
            ''' <summary>هزينه VIP</summary>
            VIP = 22
            ''' <summary>کارت هديه</summary>
            PresentCard = 23
            ''' <summary>لاندري</summary>
            Landry = 25
            ''' <summary>فروشگاه</summary>
            Shop = 26
            ''' <summary>رزرو خدمات</summary>
            ServiceReserve = 27
            ''' <summary>ترانسفر</summary>
            Transfer = 28
            ''' <summary>ملزومات اتاق</summary>
            RoomSupplies = 29
            ''' <summary>ورودي رزرو خدمات</summary>
            ServiceReserveInning = 30
            ''' <summary>اسپا</summary>
            SpaCenter = 31
            ''' <summary>پرداخت به معرف (راهنما (</summary>
            PayToLeader = 32
            ''' <summary>امتياز مشترک</summary>
            UsedScore = 33
            ''' <summary>خسارت</summary>
            Damage = 34
        End Enum

        ''' <summary>انواع مشخصه هاي سرويسها</summary>
        Public Enum ServicePropertyType
            ''' <summary>آيتم هاي ميني بار</summary>
            MinibarItem = 2
            ''' <summary>خدمات عمومي</summary>
            Service = 3
            ''' <summary>رستوران سرويس دهنده</summary>
            FoodRestaurant = 4
            ''' <summary>کد تلفني ميني بار</summary>
            TelMinibarCode = 5
            ''' <summary>مواد اوليه غذا</summary>
            ServiceItem = 6
            ''' <summary>گروه غذايي رستوران</summary>
            ResturantFoodGroups = 5
            ''' <summary>گروه غذايي تريا</summary>
            TeriaFoodGroups = 7
            ''' <summary>ارتباط سرويس ها با محل</summary>
            ServiceAndLocationRelated = 8
            ''' <summary>خواص غذا</summary>
            FoodFeatures = 9
            ''' <summary>گروه دستورالعمل غذا</summary>
            Recipe = 10
            ''' <summary>آيتم هاي ملزومات</summary>
            RoomSupplieItems = 11
            ''' <summary>غذاهاي ترکيبي</summary>
            CombinatoryFood = 12
            ''' <summary>آيتم هاي ليست منوي غذايي</summary>
            FoodListMenuItems = 13
            ''' <summary>نياز به تجهيز</summary>
            DeviceRequire = 14
        End Enum

        ''' <summary>123</summary>
        Public Enum Empty1
            ''' <summary>123</summary>
            Empty_1 = 1
        End Enum

        ''' <summary>انواع مراکز هزينه</summary>
        Public Enum CostCenterType
            ''' <summary>درآمد</summary>
            Income = 1
            ''' <summary>مانده مسافر</summary>
            GuestRemain = 2
            ''' <summary>رزرو</summary>
            Reserve = 3
            ''' <summary>قرارداد</summary>
            Contract = 4
            ''' <summary>پرسنل</summary>
            Personel = 5
            ''' <summary>صندوق</summary>
            Cash = 6
            ''' <summary>بانک</summary>
            Bank = 7
            ''' <summary>هزينه</summary>
            Cost = 8
            ''' <summary>دستگاه Pos</summary>
            Pos = 9
        End Enum

        ''' <summary>مرجع ثبت رکورد</summary>
        Public Enum RowReferenceType
            ''' <summary></summary>
            None = 1
            ''' <summary>صورتحساب</summary>
            Bill = 2
            ''' <summary>تلفن</summary>
            Telephone = 3
            ''' <summary>پارکينگ</summary>
            Parking = 4
            ''' <summary>شارژ</summary>
            Charge = 5
            ''' <summary>شارژشب قبل</summary>
            LastNightCharge = 6
            ''' <summary>اضافه شارژ</summary>
            DailyUse = 7
            ''' <summary>IPTV</summary>
            IPTV = 8
            ''' <summary>ريجسترکارت</summary>
            RegisterCard = 9
            ''' <summary>تخفيف مشترک</summary>
            SubscribDiscount = 10
            ''' <summary>رکوردهاي سيستمي</summary>
            System = 11
            ''' <summary>کنسلي رزرو</summary>
            ReserveCancel = 12
            ''' <summary>شارژ Exit زود هنگام</summary>
            RoomChargeExitEarly = 13
            ''' <summary>شارژ تاخير در ورود</summary>
            RoomChargeCheckinDelay = 14
        End Enum

        ''' <summary>نوع ارائه هزينه</summary>
        Public Enum CostOfferType
            ''' <summary>فروش</summary>
            Offer = 1
            ''' <summary>برگشت</summary>
            TurnBack = 2
        End Enum

        ''' <summary>نوع رديف جزء هزينه ها</summary>
        Public Enum CashItemRowType
            ''' <summary>اصلي</summary>
            Main = 1
            ''' <summary>نفر اضافه</summary>
            Extra = 2
            ''' <summary>رديف فرزند</summary>
            Child = 3
            ''' <summary>طرف مقابل</summary>
            Beside = 4
        End Enum

        ''' <summary>انواع رديفهاي قيمت رجيسترکارت</summary>
        Public Enum RegisterCostTypes
            ''' <summary>شارژ</summary>
            Charge = 1
            ''' <summary>ساير</summary>
            Other = 2
        End Enum

        ''' <summary>ماهيت حسابها</summary>
        Public Enum AccountNature
            ''' <summary>بدهکار</summary>
            Debit = 1
            ''' <summary>بستانکار</summary>
            Credit = 2
            ''' <summary>بدهکار/يستانکار</summary>
            DebitCredit = 3
        End Enum

        ''' <summary>روش هاي تشخيص حساب مقابل و کد مالي عوامل هزينه</summary>
        Public Enum CostCenterRecognition
            ''' <summary>نحوه پرداخت</summary>
            PayType = 1
            ''' <summary>رستوران</summary>
            Restaurant = 2
            ''' <summary>عامل هزينه پايه</summary>
            CostCenter = 3
            ''' <summary>نوع ارائه هزينه</summary>
            CostOfferType = 4
            ''' <summary>کافي شاپ</summary>
            Teria = 5
            ''' <summary>فروشگاه</summary>
            Shop = 6
        End Enum

        ''' <summary>انواع مشخصه هاي مراکز هزينه</summary>
        Public Enum CostCenterPropertyType
            ''' <summary>کد مالي</summary>
            Account = 1
            ''' <summary>طرف مقابل</summary>
            AgainstSide = 2
            ''' <summary>وابستگي به محلهاي برگزاري</summary>
            LocationDependence = 3
            ''' <summary>کد مالي طرف مقابل</summary>
            BesideAccID = 4
        End Enum

        ''' <summary>وضعيت درآمد</summary>
        Public Enum IncomeStatus
            ''' <summary>باز</summary>
            Open = 1
            ''' <summary>ثبت شده</summary>
            Register = 2
            ''' <summary>قطعي</summary>
            Definite = 3
        End Enum

        ''' <summary>وضعيت سند</summary>
        Public Enum VoucherStatus
            ''' <summary>ابطال موقت</summary>
            Cancel = 0
            ''' <summary>پيش نويس</summary>
            Temporary = 1
            ''' <summary>ثبت شده</summary>
            Register = 2
            ''' <summary>قطعي</summary>
            Definite = 3
            ''' <summary>تاييد شده</summary>
            Verify = 5
        End Enum

        ''' <summary>انواع سند</summary>
        Public Enum VoucherTypes
            ''' <summary>عمومي</summary>
            General = 1
            ''' <summary>درآمد</summary>
            Income = 2
            ''' <summary>حسابداري انبار</summary>
            Store = 3
            ''' <summary>افتتاحيه</summary>
            Opening = 4
            ''' <summary>اختتاميه</summary>
            Closing = 5
            ''' <summary>سند حقوق</summary>
            Salary = 6
            ''' <summary>حسابداري خريد</summary>
            Purchase = 7
            ''' <summary>خزانه داري-دريافت</summary>
            ChequesReceive = 8
            ''' <summary>خزانه داري-پرداخت</summary>
            ChequesIssue = 9
            ''' <summary>تنخواه</summary>
            fund = 10
            ''' <summary>بستن حساب موقت</summary>
            CloseTemporaryAccount = 11
            ''' <summary>حسابداري اموال</summary>
            Possession = 12
        End Enum

        ''' <summary>وضعيت صندوق</summary>
        Public Enum CashStatus
            ''' <summary>Delete شده</summary>
            Deleted = 0
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>برگشت داده شده</summary>
            TurnBack = 3
            ''' <summary>رديف برگشتي</summary>
            TurnBackCancel = 4
            ''' <summary>موقت</summary>
            Temp = 5
        End Enum

        ''' <summary>روشهاي تسويه حساب رجيسترکارت</summary>
        Public Enum RegisterPayoffType
            ''' <summary>نقدي</summary>
            Cash = 1
            ''' <summary>انتقال به حساب</summary>
            TransferRoom = 2
            ''' <summary>تعهد</summary>
            Guarantee = 3
        End Enum

        ''' <summary>انواع مشخصه هاي جدول صندوق</summary>
        Public Enum CashPropertyType
            ''' <summary>شماره حساب</summary>
            BankAccount = 1
            ''' <summary>ارز پرداختي</summary>
            CurrencyType = 2
            ''' <summary>تاريخ پرداخت</summary>
            PayDate = 3
        End Enum

        ''' <summary>وضعيت رزرو</summary>
        Public Enum ReserveStatus
            ''' <summary>کنسلي موقت</summary>
            TempCancel = 4
            ''' <summary>کنسلي پرداخت شده</summary>
            PayCancel = 5
            ''' <summary>کنسلي قطعي شده</summary>
            Cancel = 0
            ''' <summary>موقت</summary>
            Temporary = 1
            ''' <summary>قطعي</summary>
            Definite = 2
            ''' <summary>رجيستر شده</summary>
            Register = 3
            ''' <summary>Delete شده</summary>
            Delete = 9
        End Enum

        ''' <summary>انواع صورتحسابها</summary>
        Public Enum BillType
            ''' <summary>رستوران</summary>
            Restaurant = 1
            ''' <summary>کافي شاپ</summary>
            Teria = 2
            ''' <summary>ميني بار</summary>
            Minibar = 3
            ''' <summary>کارت هديه</summary>
            PresentCard = 4
            ''' <summary>لاندري</summary>
            Landry = 5
            ''' <summary>فروشگاه</summary>
            Shop = 6
            ''' <summary>ملزومات اتاق</summary>
            RoomSupplies = 7
            ''' <summary>خسارت</summary>
            Damage = 8
        End Enum

        ''' <summary>انواع فهرست بها</summary>
        Public Enum PriceListType
            ''' <summary>EconomyClass</summary>
            [Global] = 1
            ''' <summary>FirstClass</summary>
            FirstClass = 2
            ''' <summary>BussinesClass</summary>
            BussinesClass = 3
            ''' <summary>قيمت اتحاديه</summary>
            EtehadiePrice = 7
            ''' <summary>شرکتي</summary>
            Contract = 8
        End Enum

        ''' <summary>انواع قيمتهاي فهرست بها</summary>
        Public Enum PriceListCostType
            ''' <summary>انواع اتاقها</summary>
            RoomType = 1
            ''' <summary>غذاها-خدمات</summary>
            Service = 2
            ''' <summary>نفر اضافه</summary>
            ExtraGuest = 3
            ''' <summary>درصد ماليات بر ارزش افزوده</summary>
            DutyPercent = 4
            ''' <summary>تعرفه ورودي پارکينگ</summary>
            ParkingEnterTariff = 5
            ''' <summary>تعرفه ساعتي پارکينگ</summary>
            ParkingHourTariff = 6
            ''' <summary>تعرفه مهمانان پارکينگ</summary>
            ParkingGuestTariff = 7
            ''' <summary>درصد ماليات بر ارزش افزوده آينده</summary>
            NextDutyPercent = 8
            ''' <summary>سالن ها</summary>
            Salon = 9
            ''' <summary>کالا</summary>
            Good = 10
            ''' <summary>تخفيفات</summary>
            Discounts = 11
            ''' <summary>تعرفه ورودي آزاد اسپا</summary>
            SpaEnterTariff = 12
            ''' <summary>تعرفه زماني (دقيقه)آزاد اسپا</summary>
            SpaTimeTariff = 13
            ''' <summary>تعرفه ميهمانان ورودي اسپا</summary>
            SpaGuestEnterTariff = 14
            ''' <summary>تعرفه زماني ميهمانان (دقيقه)اسپا</summary>
            SpaTimeGuestTariff = 15
        End Enum

        ''' <summary>انواع عملگرها</summary>
        Public Enum Operators
            ''' <summary>=</summary>
            Equal = 1
            ''' <summary><></summary>
            NotEqual = 2
            ''' <summary>></summary>
            Great = 3
            ''' <summary><</summary>
            Less = 4
            ''' <summary>>=</summary>
            GreatEqual = 5
            ''' <summary><=</summary>
            LessEqual = 6
            ''' <summary> IN</summary>
            [In] = 7
            ''' <summary> NOT IN</summary>
            NotIn = 8
            ''' <summary>LIKE</summary>
            [Like] = 9
            ''' <summary>BETWEEN</summary>
            Between = 10
            ''' <summary>IS NULL</summary>
            IsNull = 11
            ''' <summary>IS NOT NULL</summary>
            IsNotNull = 12
        End Enum

        ''' <summary>مشخصه هاي کاربر</summary>
        Public Enum UserProperties
            ''' <summary>بروزرساني خودکار رک</summary>
            RackRefreshEnabled = 1
            ''' <summary>نمايش آيکون رک</summary>
            RoomIconDisplay = 2
            ''' <summary>نمايش رنگ رک</summary>
            RoomColorDisplay = 3
            ''' <summary>نمايش آيکون Exitي ها</summary>
            CheckoutStatusIcomDisplay = 4
            ''' <summary>نمايش ToolTip</summary>
            ToolTipDisplay = 5
            ''' <summary>نمايش آيکون شرکن</summary>
            ContractorIconDisplay = 6
            ''' <summary>نمايش آيکون پيغام</summary>
            MessageIcomDisplay = 7
            ''' <summary>نمايش آيکون يادداشت</summary>
            NotificationIconDisplay = 8
            ''' <summary>عنوان</summary>
            RoomTitleTransparency = 9
            ''' <summary>زمان بروزرساني رک</summary>
            RackRefreshTime = 10
            ''' <summary>نمايش آيکون مشترکين</summary>
            CustomerIconDisplay = 11
            ''' <summary>نمايش آيکون مهمان عادي</summary>
            NotCustomerIconDisplay = 12
            ''' <summary>نمايش اختصار اتاق</summary>
            ShowShortRoomName = 13
            ''' <summary>نمايش آيکن روزتولد</summary>
            ShowBirthdayIcon = 14
            ''' <summary>نمايش آيکن سالگردازدواج</summary>
            ShowMarriageDayIcon = 15
            ''' <summary>سقف مجاز دسترسي به داده هاي راکد - تعداد روز</summary>
            ArchiveDayLong = 16
            ''' <summary>جداسازي بلاک ها</summary>
            BlockSeparate = 17
        End Enum

        ''' <summary>نوع ترانسفر</summary>
        Public Enum TransferType
            ''' <summary>ورودي</summary>
            Input = 1
            ''' <summary>Exitي</summary>
            Output = 2
            ''' <summary>گشت</summary>
            Tour = 3
        End Enum

        ''' <summary>وضعيت ترانسفر</summary>
        Public Enum TransferStatus
            ''' <summary>درخواست</summary>
            Requested = 1
            ''' <summary>انجام شده</summary>
            Transfered = 2
            ''' <summary>ابطال</summary>
            Canceled = 3
        End Enum

        ''' <summary>انواع مجوزها</summary>
        Public Enum PermissionType
            ''' <summary>گروه</summary>
            Group = 1
            ''' <summary>مجوز</summary>
            Permission = 2
            ''' <summary>نقش</summary>
            Role = 3
        End Enum

        ''' <summary>انواع مشخصه مجوزها</summary>
        Public Enum PermissionPropertyType
            ''' <summary>آيتمهاي نقش</summary>
            RoleItem = 1
        End Enum

        ''' <summary>انواع اشياء سيستم</summary>
        Public Enum SystemObjectType
            ''' <summary>منو</summary>
            Menu = 1
            ''' <summary>زيرمنو</summary>
            SubMenu = 2
            ''' <summary>آيتم منو</summary>
            MenuItem = 3
            ''' <summary>سيستم</summary>
            System = 4
            ''' <summary>فرم</summary>
            Form = 5
            ''' <summary>کنترل</summary>
            Control = 6
            ''' <summary>گروه</summary>
            Group = 7
        End Enum

        ''' <summary>انواع آيکون</summary>
        Public Enum ImageType
            ''' <summary>منو</summary>
            Menu = 1
            ''' <summary>رک</summary>
            Rack = 2
            ''' <summary>آرم شرکتها</summary>
            ContractorArm = 4
        End Enum

        ''' <summary>منبع اطلاعاتي تلفن</summary>
        Public Enum TelephoneSorceBase
            ''' <summary>فايل متني</summary>
            TextFile = 1
            ''' <summary>پايگاه اطلاعاتي Access</summary>
            Access = 2
            ''' <summary>پايگاه اطلاعاتي Sql</summary>
            SqlServer = 3
        End Enum

        ''' <summary>نوع تاريخ</summary>
        Public Enum DateType
            ''' <summary>شمسي</summary>
            Solar = 1
            ''' <summary>ميلادي</summary>
            Gregorian = 2
            ''' <summary>قمري</summary>
            Lunar = 3
        End Enum

        ''' <summary>نوع ستون فايل متني</summary>
        Public Enum TextFileColumnType
            ''' <summary>طول ثابت</summary>
            FixedLength = 1
            ''' <summary>کارکتر جدا کننده</summary>
            SeparatorCharacter = 2
        End Enum

        ''' <summary>نوع کنترل تلفن</summary>
        Public Enum TelephoneControlType
            ''' <summary>پايگاه اطلاعاتي Sql</summary>
            SqlServer = 1
            ''' <summary>فايل</summary>
            File = 2
        End Enum

        ''' <summary>انواع فرمت تاريخ</summary>
        Public Enum DateFormat
            ''' <summary>mm/dd/yyyy</summary>
            mmddyyyy = 1
            ''' <summary>dd/mm/yy</summary>
            ddmmyy = 2
            ''' <summary>yy/mm/dd</summary>
            yymmdd = 3
            ''' <summary>yyyy/mm/dd</summary>
            yyyymmdd = 4
        End Enum

        ''' <summary>انواع فرمت ساعت</summary>
        Public Enum TimeFormat
            ''' <summary>h:m:s</summary>
            hms = 1
            ''' <summary>hh:mm:ss</summary>
            hhmmss = 2
            ''' <summary>h:m:s AM/MP</summary>
            hmsAM_PM = 3
            ''' <summary>hh:mm:ss AM/MP</summary>
            hhmmssAM_PM = 4
            ''' <summary>H:m:s</summary>
            Hms24 = 5
            ''' <summary>HH:mm:ss</summary>
            HHmmss24 = 6
        End Enum

        ''' <summary>انواع فرمت مدت مکالمه</summary>
        Public Enum DurationFormat
            ''' <summary>h:m:s</summary>
            hms = 1
            ''' <summary>mm:ss</summary>
            mmss = 2
            ''' <summary>دقيقه</summary>
            Minute = 3
            ''' <summary>ثانيه</summary>
            Sec = 4
        End Enum

        ''' <summary>انواع تلفنها</summary>
        Public Enum TelephoneBookItemType
            ''' <summary>منزل</summary>
            HomeNumber = 1
            ''' <summary>محل کار</summary>
            WorkNumber = 2
            ''' <summary>موبايل</summary>
            MibileNumber = 3
            ''' <summary>فکس</summary>
            FaxNumber = 4
        End Enum

        ''' <summary>انواع ضمائم</summary>
        Public Enum AttachmentType
            ''' <summary>تصوير پرسنل</summary>
            PeopleImage = 1
            ''' <summary>کپي شناسنامه</summary>
            Certificate = 2
            ''' <summary>کپي کارت ملي</summary>
            NationalCard = 3
            ''' <summary>متن نامه - قالب بندي</summary>
            LetterTextFormatted = 4
            ''' <summary>متن نامه</summary>
            LetterText = 5
            ''' <summary>ضمائم نامه</summary>
            LetterAttachment = 6
        End Enum

        ''' <summary>انواع شيفت</summary>
        Public Enum ShiftType
            ''' <summary>صندوق</summary>
            Cash = 1
            ''' <summary>رستوران</summary>
            Restaurant = 2
            ''' <summary>کافي شاپ</summary>
            Teria = 3
            ''' <summary>ساير</summary>
            Other = 9
        End Enum

        ''' <summary>وضعيت مشترکين</summary>
        Public Enum SubscribeStatus
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>غير فعال</summary>
            DeActive = 2
        End Enum

        ''' <summary>انواع PocketPc</summary>
        Public Enum PocketPcType
            ''' <summary>رستوران-ناهار</summary>
            Restaurant = 26
            ''' <summary>کافي شاپ</summary>
            Teria = 36
            ''' <summary>خانه داري</summary>
            RoomKeeping = 16
            ''' <summary>رستوران-شام</summary>
            Restaurant_D = 27
            ''' <summary>رستوران-صبحانه</summary>
            Restaurant_B = 21
        End Enum

        ''' <summary>انواع مشخصه هاي صورتحساب</summary>
        Public Enum BillPropertyType
            ''' <summary>تاريخ ارسال چاپ به صندوق</summary>
            CashPrintDate = 1
            ''' <summary> تاريخ ارسال چاپ به آشپزخانه</summary>
            KitchenPrintDate = 2
            ''' <summary>تاريخ اعتبار</summary>
            CreditDate = 3
            ''' <summary>نوع لاندري</summary>
            LandryType = 4
            ''' <summary>نوع تحويل</summary>
            DeliveryType = 5
            ''' <summary>تاريخ تقريبي تحويل</summary>
            ApproximateDeliveryDate = 6
            ''' <summary>ارسال جهت رويت آشپزخانه</summary>
            ForViewKitchenPrint = 7
            ''' <summary>تاييدرويت آشپزخانه</summary>
            VerfiyKitchenPrint = 8
            ''' <summary>تحويل غذا به مهمان</summary>
            DeliveryToGuest = 9
        End Enum

        ''' <summary>وضعيت رزروهاي اينترنتي</summary>
        Public Enum InternetReserveStatus
            ''' <summary>ابطال</summary>
            Cancel = 1
            ''' <summary>موقت</summary>
            Temporary = 2
            ''' <summary>قطعي</summary>
            Definite = 3
        End Enum

        ''' <summary>نوع واحد پرينتر</summary>
        Public Enum PrintUnitType
            ''' <summary>صندوق</summary>
            Cash = 1
            ''' <summary>واحد دسر</summary>
            DessertUnit = 2
            ''' <summary>سرويس اتاق</summary>
            RoomService = 3
            ''' <summary>برگه حسابداري </summary>
            FinancialPrint = 4
            ''' <summary>خانه داري</summary>
            RoomKeeping = 5
        End Enum

        ''' <summary>نوع تخفيف</summary>
        Public Enum DiscountType
            ''' <summary>تخفيف مشترک</summary>
            Subscrib = 1
            ''' <summary>تخفيف اينترنتي</summary>
            Internet = 2
        End Enum

        ''' <summary>نوع مقدار دامنه</summary>
        Public Enum DomainValueType
            ''' <summary>توضيحات vip</summary>
            VipDescription = 1
            ''' <summary>مبلغ Vip</summary>
            VipPrice = 2
            ''' <summary>آشپزخانه پيش فرض رستوران</summary>
            DefultResturantKitchen = 3
            ''' <summary>فهرست بهاي پيش فرض رستوران</summary>
            DefultResturantPriceList = 4
            ''' <summary>تخفيف پيش فرض رستوران</summary>
            DefultResturantDiscount = 5
            ''' <summary>حق سرويس پيش فرض رستوران</summary>
            DefultResturantService = 6
            ''' <summary>مشمول ماليات رستوران</summary>
            DefultResturantHasDuty = 7
            ''' <summary>تبديل واحد</summary>
            UnitConvert = 8
            ''' <summary>ارزش ريالي ارز</summary>
            CurrencyTypeCost = 9
            ''' <summary>نحوه پرداخت پيش فرض رستوران</summary>
            DefultResturantPayType = 10
            ''' <summary>مشمول ماليات اسپا</summary>
            DefultSpatHasDuty = 11
            ''' <summary>تخفيف پيش فرض اسپا</summary>
            DefultSpaDiscount = 12
            ''' <summary>محاسبه تعرفه ورودي ميهمان به صورت روزانه</summary>
            CalculateSpaGuestEntryDaily = 13
            ''' <summary>محدوديت رزرو اينترنتي</summary>
            InternetReserveRestriction = 14
        End Enum

        ''' <summary>نوع آژانس رزرواسيون</summary>
        Public Enum AgencyType
            ''' <summary>اعتباري</summary>
            Credit = 1
            ''' <summary>نقدي</summary>
            Cash = 2
        End Enum

        ''' <summary>وضعيت ارسال پيامک</summary>
        Public Enum SMSSendStatus
            ''' <summary>ارسال شده</summary>
            Sended = 1
            ''' <summary>خطا در ارسال</summary>
            ErrSending = 2
            ''' <summary>فعال</summary>
            Active = 3
            ''' <summary>غير فعال</summary>
            NoActive = 4
        End Enum

        ''' <summary>نوع پيامک</summary>
        Public Enum SmsRowType
            ''' <summary>رجيستر</summary>
            Register = 1
            ''' <summary>رزرو</summary>
            Reserve = 2
            ''' <summary>پشتيبان</summary>
            Supporter = 3
            ''' <summary>اشتراک</summary>
            Subscribe = 4
            ''' <summary>کنسلي رزرو قطعي</summary>
            ReserveCancel = 5
            ''' <summary>ساير متنهاي تعريف شده</summary>
            Others = 6
            ''' <summary>کنسلي رزرو موقت</summary>
            TempReserveCancel = 7
            ''' <summary>تسويه حساب رجيستر</summary>
            RegisterPayOff = 8
            ''' <summary>پيام تبريک تولد</summary>
            HappyBirthdayMessage = 9
            ''' <summary>اوقات شرعي</summary>
            PrayerTime = 10
            ''' <summary>متن پيام امتياز مشترکين </summary>
            SubscribePrivilege = 11
            ''' <summary>متن پيامک اينترنت</summary>
            ResturantInternet = 12
            ''' <summary>متن پيامک Exit مهمان</summary>
            TodayExitGuest = 13
            ''' <summary>رزرو خدمات</summary>
            SmsSend = 14
            ''' <summary>پيام تبريک تولد پرسنل</summary>
            HappyBirthdayPersonelMessage = 15
            ''' <summary>پيام تبريک ازدواج</summary>
            HappyMarriageMessage = 16
            ''' <summary>متن پيامک رزرو خدمات</summary>
            ServiceReserve = 17
            ''' <summary>پيامک اشغال اتاق مالک</summary>
            RoomOwnerCheckin = 20
            ''' <summary>پيامک تخليه اتاق مالک</summary>
            RoomOwnerCheckout = 21
            ''' <summary>تاکسي سرويس</summary>
            TaxiService = 22
            ''' <summary>پيامک تبليغاتي</summary>
            SMSAdvertising = 23
            ''' <summary>رزرو اينترنتي</summary>
            InternetReserve = 23
            ''' <summary>لينک پرداخت رزرو</summary>
            ReservePayLink = 25
            ''' <summary>اطلاع رساني مهلت پرداخت رزرو</summary>
            DeadLineReservePayLink = 26
            ''' <summary>کنسلي رزرو قطعي داراي پرداخت</summary>
            ReserveCancelCost = 27
            ''' <summary>کنسلي رزرو موقت داراي پرداخت</summary>
            TempReserveCancelCost = 28
        End Enum

        ''' <summary>نوع محاسبه هزينه ها</summary>
        Public Enum CostCalculationType
            ''' <summary>فهرست بها</summary>
            PriceList = 1
            ''' <summary>طبق قرارداد</summary>
            Contract = 2
        End Enum

        ''' <summary>انواع منبع ضمائم</summary>
        Public Enum AttachmentReferenceType
            ''' <summary>رجيستر</summary>
            Register = 1
            ''' <summary>رزرو</summary>
            Reserve = 2
            ''' <summary>سند حسابداري</summary>
            Vouchers = 3
            ''' <summary>گزارشات دايناميک چاپ</summary>
            Cheques = 4
            ''' <summary>اتوماسيون اداري</summary>
            OfficeAutomation = 5
            ''' <summary>سوابق تنبيهات</summary>
            Grueling = 6
            ''' <summary>سوابق تشويقات</summary>
            Encouragement = 7
            ''' <summary>مدارک دوره هاي آموزشي</summary>
            PeopleEducationDocument = 8
            ''' <summary>برگه هاي انبار</summary>
            StoreDocuments = 9
        End Enum

        ''' <summary>انواع تخفيف کارت اشتراک</summary>
        Public Enum DiscountPropertiesType
            ''' <summary>اقامت</summary>
            Room = 1
            ''' <summary>رستوران</summary>
            Restaurant = 2
            ''' <summary>کافي شاپ</summary>
            Teria = 4
            ''' <summary>لاندري</summary>
            Landry = 4
            ''' <summary>فروشگاه</summary>
            Shop = 5
            ''' <summary>اسپا</summary>
            Spa = 6
        End Enum

        ''' <summary>نوع مهمان</summary>
        Public Enum GuestAgeTypes
            ''' <summary>تمام بها</summary>
            FullCost = 1
            ''' <summary>نيمه بها</summary>
            HalfCost = 2
        End Enum

        ''' <summary>نوع تحويل صورتحساب</summary>
        Public Enum BillDeliveryType
            ''' <summary>فوري</summary>
            Fast = 1
            ''' <summary>عادي</summary>
            Normal = 2
        End Enum

        ''' <summary>نوع کارت شناسايي</summary>
        Public Enum IdentityCardTypes
            ''' <summary>کارت ملي</summary>
            NationalCard = 1
            ''' <summary>شناسنامه</summary>
            Certificate = 2
            ''' <summary>گواهينامه</summary>
            Diploma = 3
            ''' <summary>پاسپورت</summary>
            Passport = 4
            ''' <summary>سند ازدواج</summary>
            MarriageCertificate = 5
            ''' <summary>دفترچه بيمه</summary>
            HealthInsuranceCard = 6
            ''' <summary>پايان خدمت</summary>
            MilitaryCard = 7
        End Enum

        ''' <summary>RegisterTransferانواع رکودهاي جدول</summary>
        Public Enum RegisterTransferType
            ''' <summary>بن نفر اضافه تمام بها</summary>
            ExtraFullPrint = 1
            ''' <summary>بن نفر اضافه نيمه بها</summary>
            ExtraHalfPrint = 2
            ''' <summary>بن نفراضافه زير سن محاسبه</summary>
            NotAccountingPrint = 3
        End Enum

        ''' <summary>انواع تغييرات اطلاعات</summary>
        Public Enum ModifyType
            ''' <summary>اصلاح کاربر</summary>
            UserModify = 1
            ''' <summary>رجيستر کارت</summary>
            RegisterCart = 2
            ''' <summary>تعويض قرارداد</summary>
            ContractChange = 3
            ''' <summary>تعويض اتاق</summary>
            RoomChange = 4
        End Enum

        ''' <summary>وضعيت ميز</summary>
        Public Enum LocationStatus
            ''' <summary>خالي</summary>
            Free = 1
            ''' <summary>در حال سفارش</summary>
            Enjoin = 2
            ''' <summary>منتظر ثبت ميزبان</summary>
            WaitForSave = 3
            ''' <summary>ثبت شده</summary>
            Saved = 4
            ''' <summary>در حال سرو</summary>
            Eating = 5
            ''' <summary>تخليه-در حال سرويس</summary>
            Checkout = 6
            ''' <summary>پرداخت</summary>
            PayOff = 7
        End Enum

        ''' <summary>نوع ايميل</summary>
        Public Enum EmailRowType
            ''' <summary>تاييديه رزرو</summary>
            Reserve = 1
            ''' <summary>تسويه حساب رجيستر</summary>
            RegisterPayOff = 2
            ''' <summary>تولد</summary>
            Birthday = 3
            ''' <summary>رزرو خدمات</summary>
            EmailSend = 4
            ''' <summary>ارسال ايميل بعد از ثبت مشترک</summary>
            EmailSendAfterSubscribeRegister = 5
        End Enum

        ''' <summary>انواع گارانتي قرارداد</summary>
        Public Enum ContractGuaranteeTypes
            ''' <summary>اتاق</summary>
            Room = 1
            ''' <summary>سالن</summary>
            Salon = 2
            ''' <summary>غذا</summary>
            Food = 3
            ''' <summary>ميان وعده</summary>
            Teria = 4
            ''' <summary>ساير خدمات</summary>
            OtherService = 5
        End Enum

        ''' <summary>انواع مشخصه قرارداد</summary>
        Public Enum ContractPropertyType
            ''' <summary>شارژ قرارداد</summary>
            ContarctCharge = 1
            ''' <summary>تعداد شب اقامت براي شارژ رايگان</summary>
            NumberNightsFreeCharge = 3
            ''' <summary>شماره سريال</summary>
            SerialNo = 4
            ''' <summary>کارمزد</summary>
            Wage = 2
        End Enum

        ''' <summary>انواع اطلاعات مشخصات هتل</summary>
        Public Enum HotelConfigurationType
            ''' <summary>نام هتل</summary>
            Title = 1
            ''' <summary>نوع هتل</summary>
            Type = 2
            ''' <summary>الياس</summary>
            Aliass = 3
            ''' <summary>آدرس کامل</summary>
            Address = 4
            ''' <summary>کد اقتصادي</summary>
            EconomicCode = 5
            ''' <summary>شناسه ملي</summary>
            NationalID = 6
            ''' <summary>شماره تلفن</summary>
            TelNo = 7
            ''' <summary>کد پستي</summary>
            ZipCode = 8
            ''' <summary>خلاصه آدرس</summary>
            MiniAddress = 9
            ''' <summary>مسير فايل دارائي</summary>
            DaraieFilePath = 10
            ''' <summary>شماره پرونده</summary>
            DocumentNumberTax = 11
            ''' <summary>کد شعبه</summary>
            BranchCodeTax = 12
            ''' <summary>نوع شخصيت پرداخت کننده حقوق</summary>
            PaymentType = 13
            ''' <summary>نوع شخص حقوقي پرداخت کننده حقوق</summary>
            LegalEntityTypeTax = 14
            ''' <summary>نام پرداخت کننده حقوق</summary>
            PaymentNameTax = 15
            ''' <summary>نام خانوادگي پرداخت کننده حقوق / شرکت</summary>
            PaymentFamilyTax = 16
            ''' <summary>نام شعبه</summary>
            BranchNameTax = 17
            ''' <summary>شماره ملي صاحب امضاء مجاز-اول</summary>
            NationalCode1Tax = 18
            ''' <summary>نام صاحب امضاء مجاز-اول</summary>
            Name1Tax = 19
            ''' <summary>نام خانوادگي صاحب امضاءمجاز-اول</summary>
            Family1Tax = 20
            ''' <summary>سمت صاحب امضاء مجاز-اول</summary>
            Post1Tax = 21
            ''' <summary>شماره ملي صاحب امضاءمجاز-دوم</summary>
            NationalCode2Tax = 22
            ''' <summary>نام صاحب امضاء مجاز-دوم</summary>
            Name2Tax = 23
            ''' <summary>نام خانوادگي صاحب امضاء مجاز - دوم</summary>
            Family2Tax = 24
            ''' <summary>سمت صاحب امضاء مجاز-دوم</summary>
            Post2Tax = 25
            ''' <summary>آدرس لاتين هتل</summary>
            LatinAddressOfHotel = 26
            ''' <summary>آدرس عربي هتل</summary>
            ArabicAddressOfHotel = 27
            ''' <summary>نام استان</summary>
            Province = 28
            ''' <summary>نام شهر</summary>
            City = 29
        End Enum

        ''' <summary>درخواستهاي اتاق</summary>
        Public Enum RoomRequests
            ''' <summary>ورود به اتاق</summary>
            Checkin = 1
            ''' <summary>مزاحم نشويد</summary>
            DoNotDistrub = 2
            ''' <summary>درخواست نظافت</summary>
            MakeUp = 3
            ''' <summary>درخواست لاندري</summary>
            LandryRequest = 4
            ''' <summary>دماي اتاق</summary>
            Temperature = 5
        End Enum

        ''' <summary>انواع قيمت گذاري کالا</summary>
        Public Enum GoodPriceingType
            ''' <summary>ميانگين</summary>
            Average = 1
            ''' <summary>FIFO</summary>
            FIFO = 2
            ''' <summary>LIFO</summary>
            LIFO = 3
        End Enum

        ''' <summary>انواع قيمت تمام شده </summary>
        Public Enum CostControlType
            ''' <summary>حقوق و دستمزد</summary>
            Salary = 1
            ''' <summary>استهلاک</summary>
            WearOff = 2
            ''' <summary>هزينه سربار</summary>
            OverheadCost = 3
        End Enum

        ''' <summary>انواع محلهاي قيمت تمام شده</summary>
        Public Enum CostControlPlaceType
            ''' <summary>اغذيه و اشربه - رستوران ها</summary>
            Restaurant = 1
            ''' <summary>اغذيه و اشربه - کافي شاپ ها</summary>
            Teria = 2
            ''' <summary>لاندري ها</summary>
            Landry = 3
            ''' <summary>واحدهاي اقامتي</summary>
            Room = 4
        End Enum

        ''' <summary>انواع مستندات انبار</summary>
        Public Enum StoreDocumentType
            ''' <summary>موجودي اول دوره</summary>
            PrimaryInventory = 1
            ''' <summary>رسيد</summary>
            Receipt = 2
            ''' <summary>حواله</summary>
            Draft = 3
            ''' <summary>رسيد برگشتي</summary>
            ReturnReceipt = 4
            ''' <summary>حواله انتقال</summary>
            TransferDraft = 5
            ''' <summary>رسيد انتقال</summary>
            TransferReceipt = 6
            ''' <summary>حواله کسورات</summary>
            DiductionDraft = 7
            ''' <summary>رسيد اضافات</summary>
            ExtraReceipt = 8
            ''' <summary>حواله مصرف مستقيم</summary>
            DraftDirectConsumption = 9
            ''' <summary>رسيد مصرف مستقيم</summary>
            ReceiptDirectConsumption = 10
            ''' <summary>حواله برگشت از خريد</summary>
            TurnBackDraft = 11
            ''' <summary>حواله برگشت از انبارک</summary>
            TurnBackBinDraft = 12
            ''' <summary>حواله تعديل</summary>
            DraftBalance = 13
            ''' <summary>رسيد تعديل</summary>
            ReciptBalance = 14
        End Enum

        ''' <summary>تنظيمات صبحانه</summary>
        Public Enum BreakfastSetting
            ''' <summary>دسته بن</summary>
            BillSerial = 1
            ''' <summary>رستوران</summary>
            Resturant = 2
            ''' <summary>غذاي صبحانه</summary>
            Food = 3
            ''' <summary>حداکثر زمان استفاده</summary>
            MaxTime = 4
            ''' <summary>بن صبحانه رايگان بر اساس نفرات رجيستر</summary>
            BreakfastByRegister = 5
        End Enum

        ''' <summary>نوع درخواست کالا</summary>
        Public Enum GoodRequestType
            ''' <summary>درخواست کالا</summary>
            GoodRequest = 1
            ''' <summary>درخواست خريد</summary>
            PurchaseRequest = 2
            ''' <summary>درخواست شارژ انبار</summary>
            StoreChargeRequest = 3
            ''' <summary>درخواست برگشت کالا</summary>
            TurnBackGoodRequest = 4
            ''' <summary>درخواست برگشت از خريد</summary>
            TurnBackBuyRequest = 5
        End Enum

        ''' <summary>انواع انبار گرداني</summary>
        Public Enum StoreHandlingTypes
            ''' <summary>ساليانه</summary>
            Yearly = 1
            ''' <summary>طي دوره</summary>
            Period = 2
            ''' <summary>تعديل انحراف</summary>
            AdjustedDeviation = 3
        End Enum

        ''' <summary>نوع انبار</summary>
        Public Enum StoreTypes
            ''' <summary>انبار</summary>
            Store = 1
            ''' <summary>انبارک</summary>
            Bin = 2
        End Enum

        ''' <summary>نوع تحويل کالا</summary>
        Public Enum GoodDeliveryType
            ''' <summary>انبار</summary>
            Store = 1
            ''' <summary>مستقيم</summary>
            Direct = 2
        End Enum

        ''' <summary>وضعيت درخواست کالا</summary>
        Public Enum GoodRequestStatus
            ''' <summary>صدور درخواست</summary>
            IssueRequest = 1
            ''' <summary>ابطال</summary>
            Revoke = 2
            ''' <summary>تائيد نيازمندي</summary>
            VerificationRequirements = 3
            ''' <summary>تائيد نهائي</summary>
            VerifyRequest = 4
            ''' <summary>تصويب درخواست</summary>
            ApproveRequest = 5
            ''' <summary>کنترل اعتبار</summary>
            CreditControl = 6
            ''' <summary>کنترل موجودي</summary>
            StockControl = 7
            ''' <summary>حواله موقت</summary>
            TemporaryDraft = 8
            ''' <summary>تحويل کالا از انبار</summary>
            DeliveryFromStore = 9
            ''' <summary>خريد مستقيم</summary>
            DirectPurchase = 10
            ''' <summary>تحويل مستقيم</summary>
            DirectDelivery = 11
            ''' <summary>خريد انباري</summary>
            StorePurchase = 12
            ''' <summary>صف انتظار</summary>
            WaitingList = 13
            ''' <summary>تحويل از خريد</summary>
            DeliveryOfPurchase = 14
            ''' <summary>تحويل از صف انتظار</summary>
            DeliveryOfWaitingList = 15
            ''' <summary>خريد از صف انتظار</summary>
            PurchaseOfWaitingList = 16
            ''' <summary>تعيين فروشنده</summary>
            DifineSeller = 17
        End Enum

        ''' <summary>وضعيت کالا</summary>
        Public Enum GoodStatus
            ''' <summary>نو</summary>
            [New] = 1
            ''' <summary>مستعمل</summary>
            Old = 2
        End Enum

        ''' <summary>نوع sqript</summary>
        Public Enum SgriptType
            ''' <summary>TABLE</summary>
            TABLE = 1
            ''' <summary>ALTER TABLE</summary>
            ALTER_TABLE = 2
            ''' <summary>DOMAIN</summary>
            DOMAIN = 3
            ''' <summary>FUN</summary>
            FUN = 4
            ''' <summary>SP</summary>
            SP = 5
            ''' <summary>VIEW</summary>
            VIEW = 6
            ''' <summary>OTHER</summary>
            OTHER = 7
        End Enum

        ''' <summary>Delete شود-Recipe انواع</summary>
        Public Enum TypeOfRecipe
            ''' <summary>لاندري</summary>
            Landry = 1
            ''' <summary>اغذيه و اشربه</summary>
            Food = 2
            ''' <summary>ملزومات</summary>
            Supplies = 3
        End Enum

        ''' <summary>انواع مشخصه هاي درخواست کالا</summary>
        Public Enum GoodRequestPropertyTypes
            ''' <summary>مبدا برگشت کالا</summary>
            ReturnSource = 1
            ''' <summary>شناسه حواله برگشتي</summary>
            ReturnDraftID = 2
            ''' <summary>انبارک حواله برگشتي</summary>
            ReturnBin = 3
            ''' <summary>فروشنده برگشت از خريد</summary>
            ReturnPurchase = 4
        End Enum

        ''' <summary>سطوح دستور کار مالي</summary>
        Public Enum AccountLevels
            ''' <summary>کل</summary>
            Level1 = 1
            ''' <summary>معين</summary>
            Level2 = 2
            ''' <summary>تفضيلي 1</summary>
            Level3 = 3
            ''' <summary>تفضيلي 2</summary>
            Level4 = 4
            ''' <summary>تفضيلي 3</summary>
            Level5 = 5
            ''' <summary>تفضيلي4</summary>
            LEVEL6 = 6
            ''' <summary>تفضيلي5</summary>
            LEVEL7 = 7
        End Enum

        ''' <summary>وضعيت غذاهاي باقي مانده</summary>
        Public Enum StatusRemainFood
            ''' <summary>مصرف پرسنلي</summary>
            PersonelUsage = 1
            ''' <summary>مصرف وعده بعدي</summary>
            NextMealUsage = 2
            ''' <summary>مصرف رسيپي</summary>
            RecipeUsage = 3
            ''' <summary>ساير</summary>
            OtherUsage = 4
            ''' <summary>ضايعات</summary>
            WasteUsage = 5
            ''' <summary>مصرف جاري</summary>
            CurrentUsage = 6
        End Enum

        ''' <summary>انواع مشخصه هاي انبار</summary>
        Public Enum StorePropertyType
            ''' <summary>گروه هاي کالا</summary>
            GoodType = 1
            ''' <summary>محل ارائه</summary>
            ConsumePlace = 2
        End Enum

        ''' <summary>نوع حسابها</summary>
        Public Enum TypesOfAccounts
            ''' <summary>جاري</summary>
            CurrentAccount = 1
            ''' <summary>سپرده</summary>
            SavingAccount = 2
        End Enum

        ''' <summary>انواع چک</summary>
        Public Enum TypesOfCheques
            ''' <summary>چک خاص</summary>
            SpecialCheque = 1
            ''' <summary>چک پول</summary>
            MoneyCheque = 2
            ''' <summary>چک ضمانتي</summary>
            SponsorshipCheque = 3
        End Enum

        ''' <summary>عمليات چک</summary>
        Public Enum OperationsOfCheques
            ''' <summary>دريافتي</summary>
            CurrentAccount = 1
            ''' <summary>پرداختي</summary>
            SavingAccount = 2
        End Enum

        ''' <summary>وضعيت چک</summary>
        Public Enum StatusOfCheques
            ''' <summary>فعال </summary>
            Active = 1
            ''' <summary>صادرشده</summary>
            Issued = 2
            ''' <summary>باطل شده</summary>
            Canceled = 3
            ''' <summary>باطل شده-سند خورده</summary>
            CanceledDocumented = 4
            ''' <summary>صادر شده- سند حساب پرداختني</summary>
            TemproryDocumented = 5
            ''' <summary>عودت شده</summary>
            Returned = 6
            ''' <summary>پاس شده</summary>
            DefiniteDocumented = 7
            ''' <summary>Delete شده</summary>
            Deleted = 8
            ''' <summary>اسناد نزد صندوق</summary>
            TheCash = 9
            ''' <summary>اسناد نزد بانک</summary>
            TheBank = 10
            ''' <summary>خرج شده</summary>
            Spent = 11
            ''' <summary>برگشت خورده</summary>
            ReturnFromBank = 12
        End Enum

        ''' <summary>تنظيمات پيام صوتي</summary>
        Public Enum AudioMessageSetting
            ''' <summary>نام کاربري</summary>
            UserName = 1
            ''' <summary>رمز عبور</summary>
            Password = 2
            ''' <summary>ارسال پيغام ورود ميهمان</summary>
            SendCheckinAudio = 3
            ''' <summary>ارسال پيغام Exit ميهمان</summary>
            SendCheckOutAudio = 4
            ''' <summary>ارسال پيغام روز اول اقامت ميهمان</summary>
            SendFirstResidentAudio = 5
            ''' <summary>ارسال پيغام تاييديه رزرو</summary>
            SendReserveVerifyAudio = 6
        End Enum

        ''' <summary>تنظيمات انبار و کاست کنترل</summary>
        Public Enum StoreAndCostControlSetting
            ''' <summary>تاريخ شروع کاست کنترل</summary>
            DateOfStartCostControl = 1
            ''' <summary>ديتابيس فعال انبار</summary>
            StoreSysActiveDataBase = 2
            ''' <summary>سرور و نام کاربري ديتابيس انبار</summary>
            StoreSysDataBaseIp = 3
            ''' <summary>فعال سازي کارتابل</summary>
            ActiveKartable = 4
            ''' <summary>حداقل طول کد کالا</summary>
            MinimumLengthProductCode = 5
            ''' <summary>حداکثر طول کد کالا</summary>
            MaximumLengthProductCode = 6
            ''' <summary>ويرايش درخواست ها همراه با رسيد/حواله</summary>
            EditRequestWithStoreDocuments = 7
            ''' <summary>عدم ثبت تفصيلي انبار براي اسناد</summary>
            NotCertainRecordStores = 8
            ''' <summary>ديتابيس انبار نرم افزار پايا</summary>
            DataBaseStockOfPAYA = 9
            ''' <summary>ثبت مبلغ رسيدبدون ماليات</summary>
            PriceOfReceiptWithoutTax = 10
            ''' <summary>کد انبار براي انتقال مصرف مستقيم</summary>
            CodeOfStoreForDirectConsumption = 11
            ''' <summary>صدور سند رسيد همراه با حواله مستقيم</summary>
            CreateDocReceiptWithDraftDirectConsumption = 12
            ''' <summary>صدوررسيد مستقيم براساس نوع تحويل کالا</summary>
            IssuingDirectReceiptWithDeliveryType = 13
            ''' <summary>کدينگ مالي ماليات</summary>
            TaxAccCode = 14
            ''' <summary>عدم بررسي کد فاکتور تکراري</summary>
            NotCheckDuplicateCodeFactor = 15
            ''' <summary>نمايش شماره حواله در بدهکار سند گردش ريالي</summary>
            UseCodeDraftInDebitDocOfValuation = 17
            ''' <summary>نمايش عنوان کالا در سند گردش ريالي انبار</summary>
            UseGoodTitleInStoreValuationDoc = 18
            ''' <summary>نمايش عنوان کالا در سند رسيد انبار</summary>
            UseGoodTitleInStoreReciptDoc = 19
            ''' <summary>ثبت صورت مجلس تحويل کالا</summary>
            UseParliamentDocumentGood = 20
            ''' <summary>عدم کنترل وعده هاي غذايي در ثبت منو</summary>
            DontCheckCCIDInInsertMenu = 21
            ''' <summary>عدم بسته شدن فرم ثبت رسيدوحواله پس از ثبت</summary>
            DontCloseFrmReceiptAndDraftAfterInsert = 22
            ''' <summary>عدم ثبت مبالغ سرشکن در فاکتور</summary>
            DontRecordPriceProrateOfFactor = 23
            ''' <summary>عدم ثبت حواله درخواست کالا پس از ثبت رسيد</summary>
            DontRecordDraftOfGoodRequestAfterReceipt = 24
            ''' <summary>استفاده از منوي غذايي جديد</summary>
            UseNewFoodMenu = 25
            ''' <summary>عدم انتقال مانده غذاي منوي جاري</summary>
            DontTransferFoodRemainQuantity = 26
            ''' <summary>نمايش شماره فاکتوردر رديف سندو فروشنده در هدر سند</summary>
            ShowFactorCodeInDetailOfDocAndPurchase = 27
            ''' <summary>نمايش تمامي کالاها در صدور سند رسيد</summary>
            ShowAllGoodsTitleInDocReceipt = 28
            ''' <summary>سيستم کاست کنترل پيشرفته</summary>
            CostControlAdvanced = 29
            ''' <summary>شناسه ي بن رستوران پرسنلي</summary>
            PeoIdPersonelUsage = 30
            ''' <summary>نمايش تمامي کالاها در صدور سند حواله</summary>
            ShowAllGoodsTitleInDocDraft = 31
            ''' <summary>صدور شماره رسيد/حواله سريال</summary>
            CodeOfStoreDocumentIsSerial = 32
            ''' <summary>عدم نمايش موجودي انبار</summary>
            DontShowInventoryStore = 33
            ''' <summary>کدينگ مالي تخفيف</summary>
            DiscountAccCode = 35
            ''' <summary>صدور درخواست کالا همراه با کنترل موجودي</summary>
            IssuanceGoodRequestWithInventoryControl = 36
            ''' <summary>آيا کنترل کالاهاي هر محل مصرف انجام شود</summary>
            CheckConsumePlaceGoods = 37
            ''' <summary>ارسال خودکار چاپ حواله</summary>
            SendAutoPrintOfDraft = 38
            ''' <summary>عدم بازشدن خودکارپنجره ي Select کالا</summary>
            DontOpenAutoWindowOfSelectGood = 39
            ''' <summary>چاپ ته برگ موجودي اول دوره</summary>
            FooterPrimaryInventory = 40
            ''' <summary>چاپ ته برگ رسيد انبار</summary>
            FooterReceipt = 41
            ''' <summary>چاپ ته برگ حواله انبار</summary>
            FooterDraft = 42
            ''' <summary>چاپ ته برگ رسيد برگشتي</summary>
            FooterReturnReceipt = 43
            ''' <summary>چاپ ته برگ حواله انتقال</summary>
            FooterTransferDraft = 44
            ''' <summary>چاپ ته برگ رسيد انتقال</summary>
            FooterTransferReceipt = 45
            ''' <summary>چاپ ته برگ حواله کسورات</summary>
            FooterDiductionDraft = 46
            ''' <summary>چاپ ته برگ رسيد اضافات</summary>
            FooterExtraReceipt = 47
            ''' <summary>چاپ ته برگ فاکتور</summary>
            FooterFactor = 48
            ''' <summary>چاپ ته برگ حواله برگشت از خريد</summary>
            FooterTurnBackDraft = 49
            ''' <summary>چاپ ته برگ حواله برگشت از انبارک</summary>
            FooterTurnBackBinDraft = 50
            ''' <summary>چاپ ته برگ حواله تعديل</summary>
            FooterDraftBalance = 52
            ''' <summary>چاپ ته برگ رسيد تعديل</summary>
            FooterReciptBalance = 53
            ''' <summary>آيا صدور سند به تفکيک انبار صادر شود ؟</summary>
            GenerateVoucherValuationGroupByStore = 54
            ''' <summary>کدينگ عوارض شهرداري</summary>
            DuesAccCode = 55
            ''' <summary>کدينگ ساير هزينه ها</summary>
            OtherPriceCode = 56
            ''' <summary>کدينگ هزينه حمل</summary>
            CarryPriceCode = 57
            ''' <summary>ثبت رسيپي بوفه در منوي غذايي</summary>
            AddRecipeOfBuffetToMenu = 51
            ''' <summary>آيا هر کاربر تنها درخواستهاي کالاي مربوط به خود را ببيند ؟</summary>
            ShowOnlyUserRequestGood = 58
        End Enum

        ''' <summary>نوع گروه حساب</summary>
        Public Enum AccountingGroupType
            ''' <summary>سود و زياني</summary>
            ProfitAndLoss = 1
            ''' <summary>ترازنامه اي</summary>
            BalanceSheet = 1
            ''' <summary>انتظامي</summary>
            Disciplinary = 1
        End Enum

        ''' <summary>انواع پيام صوتي</summary>
        Public Enum AudioMessageType
            ''' <summary>ورود ميهمان</summary>
            CheckIn = 1
            ''' <summary>Exit ميهمان</summary>
            CheckOut = 2
            ''' <summary>روز اول اقامت ميهمان</summary>
            FirstResident = 3
            ''' <summary>تاييديه رزرو</summary>
            ReserveVerify = 4
            ''' <summary>متفرقه</summary>
            Others = 5
        End Enum

        ''' <summary>تنظيمات PC POS</summary>
        Public Enum PcPosSetting
            ''' <summary>آدرس IP</summary>
            IpAdress = 1
            ''' <summary>شناسه حساب پيش فرض</summary>
            DefualtBankAccountId = 2
            ''' <summary>آدرس سرور</summary>
            ServerAddress = 3
            ''' <summary>Token</summary>
            Token = 3
        End Enum

        ''' <summary>مراکز کنترل هزينه</summary>
        Public Enum CostControlCenters
            ''' <summary>غذا و نوشابه</summary>
            CostFood = 1
            ''' <summary>واحدهاي اقامتي</summary>
            CostRooms = 2
            ''' <summary>لاندري</summary>
            CostLandry = 3
            ''' <summary>تريا</summary>
            CostTeria = 4
        End Enum

        ''' <summary>نوع سند چک</summary>
        Public Enum TypeOfDocCheque
            ''' <summary> حسابهاي موقت</summary>
            TemporaryAccount = 1
            ''' <summary>  حسابهاي بانک</summary>
            BankAccount = 2
        End Enum

        ''' <summary>انواع محتواي کارتابل</summary>
        Public Enum ContentType
            ''' <summary>درخواست کالا</summary>
            GoodRequest = 1
            ''' <summary>سند حسابداري</summary>
            Vouchers = 2
            ''' <summary>درخواست خريد</summary>
            PurchaseRequest = 3
            ''' <summary>صورتحساب خريد</summary>
            PurchaseBill = 4
            ''' <summary>صدوراسناد انبار</summary>
            IssuingStoreDoc = 5
            ''' <summary>اتوماسيون اداري</summary>
            OfficeAutomation = 6
            ''' <summary>چک</summary>
            Cheques = 7
            ''' <summary>وجه نقد</summary>
            Money = 8
            ''' <summary>درخواست نظرسنجي</summary>
            VoteRequest = 9
            ''' <summary>دستورکار</summary>
            JobWorker = 10
            ''' <summary>حواله</summary>
            Assignment = 11
            ''' <summary>کارمزد/هزينه</summary>
            Cost = 12
            ''' <summary>چک انتظامي</summary>
            Discipline = 13
            ''' <summary>سفته</summary>
            Paper = 14
            ''' <summary>درخواست خدمات</summary>
            ServiceRequest = 15
        End Enum

        ''' <summary>نوع اقدام کارتابل</summary>
        Public Enum PerformType
            ''' <summary>ابطال</summary>
            Cancle = 1
            ''' <summary>برگشت</summary>
            TurnBack = 2
            ''' <summary>تاييد</summary>
            Verify = 3
            ''' <summary>مشاهده شده</summary>
            Viewed = 4
            ''' <summary>مشاهده نشده</summary>
            NotViewed = 5
            ''' <summary>پايان گردش</summary>
            Finished = 6
            ''' <summary>واگذار شده</summary>
            Transferred = 7
            ''' <summary>معلق</summary>
            suspend = 8
        End Enum

        ''' <summary>علت وضعيت چک</summary>
        Public Enum ReasonOfChequesStatus
            ''' <summary>مخدوش شده</summary>
            Altered = 1
            ''' <summary>برگشت</summary>
            Returned = 2
        End Enum

        ''' <summary>انواع ضمائم رديف سند</summary>
        Public Enum TypeOfContentsDocument
            ''' <summary>چک</summary>
            Cheque = 1
            ''' <summary>فيش بانکي</summary>
            BankReceipt = 2
        End Enum

        ''' <summary>سطوح دسترسي</summary>
        Public Enum AppendType
            ''' <summary>تهي</summary>
            None = 1
            ''' <summary>حواله انبار</summary>
            Draft = 2
            ''' <summary>رسيد انبار</summary>
            Receipt = 3
            ''' <summary>صندوق</summary>
            Cash = 4
            ''' <summary>حقوق و دستمزد</summary>
            Salary = 5
            ''' <summary>چک</summary>
            Cheques = 6
            ''' <summary>اموال</summary>
            Possession = 7
        End Enum

        ''' <summary>انواع دوره هاي خدمات رزرو</summary>
        Public Enum ServiceCyclesType
            ''' <summary>تالار</summary>
            Talar = 1
            ''' <summary>رستوران</summary>
            Resturant = 2
            ''' <summary>عمومي</summary>
            General = 3
        End Enum

        ''' <summary>نوع فرمول</summary>
        Public Enum SalaryFormulaType
            ''' <summary>حکم</summary>
            Agreement = 1
            ''' <summary>حقوق</summary>
            Salary = 2
        End Enum

        ''' <summary>نوع گروه فرمولها</summary>
        Public Enum SalaryFormulaGroup
            ''' <summary>مزايا</summary>
            Benefit = 1
            ''' <summary>کسورات</summary>
            Deducts = 2
            ''' <summary>امتياز</summary>
            Score = 3
            ''' <summary>مشخصات</summary>
            Properties = 4
        End Enum

        ''' <summary>نوع محاسبات فرمولهاي حقوق</summary>
        Public Enum SalaryFormulaCalculationType
            ''' <summary>محاسباتي</summary>
            Calculation = 1
            ''' <summary>ثابت</summary>
            Constant = 2
            ''' <summary>حکمي</summary>
            Prescription = 3
        End Enum

        ''' <summary>وضعيت رزرو غذا</summary>
        Public Enum FoodReserveStatus
            ''' <summary>منو</summary>
            InList = 1
            ''' <summary>مازاد</summary>
            ExtendedToList = 2
        End Enum

        ''' <summary>نوع پرداختي</summary>
        Public Enum SalaryType
            ''' <summary>ماهيانه</summary>
            Monthly = 1
            ''' <summary>خارج از ليست</summary>
            OffTheList = 2
            ''' <summary>معوقه</summary>
            Delayed = 3
        End Enum

        ''' <summary>نوع مقادير</summary>
        Public Enum ValueType
            ''' <summary>عدد</summary>
            IsInteger = 1
            ''' <summary>رشته</summary>
            IsString = 2
            ''' <summary>بله/خير</summary>
            IsBoolean = 3
            ''' <summary>عددي بزرگ</summary>
            IsLong = 2
            ''' <summary>اعشار</summary>
            IsDouble = 3
        End Enum

        ''' <summary>نوع کنترل</summary>
        Public Enum ControlType
            ''' <summary>TextBox</summary>
            TextBox = 1
            ''' <summary>ComboBox</summary>
            ComboBox = 2
            ''' <summary>CheckBox</summary>
            CheckBox = 3
        End Enum

        ''' <summary>انواع نامه ها</summary>
        Public Enum LetterType
            ''' <summary>درون سازماني</summary>
            InOffice = 0
            ''' <summary>وارده</summary>
            ComerLetter = 1
            ''' <summary>صادره</summary>
            OuterLetter = 2
        End Enum

        ''' <summary>نوع مشخصه چک</summary>
        Public Enum ChequesPropertyType
            ''' <summary>سند</summary>
            Voucher = 1
            ''' <summary>طرف مقابل</summary>
            Beside = 2
            ''' <summary>تاريخچه</summary>
            History = 3
        End Enum

        ''' <summary>انواع صدور درخواست</summary>
        Public Enum RequestType
            ''' <summary>درخواست صدور چک</summary>
            IssueChequesRequest = 1
            ''' <summary>درخواست برداشت وجه</summary>
            ConceptionMoneyRequest = 2
            ''' <summary>درخواست مرخصي روزانه</summary>
            DayOffRequest = 3
            ''' <summary>درخواست مرخصي ساعتي</summary>
            HourOffRequest = 4
            ''' <summary>درخواست اضافه کار ساعتي </summary>
            HourOverTimeRequest = 5
            ''' <summary>درخواست مرخصي استعلاجي</summary>
            DayOffDemandRequest = 6
            ''' <summary>درخواست ماموريت روزانه</summary>
            DailydutyRequests = 6
            ''' <summary>درخواست ماموريت ساعتي</summary>
            HourDutyRequests = 6
            ''' <summary>درخواست صدور حواله</summary>
            AssignmentRequest = 7
            ''' <summary>درخواست صدور کارمزد/هزينه</summary>
            CostRequest = 8
            ''' <summary>درخواست صدور چک انتظامي</summary>
            DisciplineRequest = 9
            ''' <summary>درخواست صدور سفته</summary>
            PaperRequest = 10
        End Enum

        ''' <summary>وضعيت درخواست</summary>
        Public Enum RequestStatus
            ''' <summary>درحال گردش</summary>
            InReferral = 1
            ''' <summary>پايان گردش</summary>
            EndReferral = 2
            ''' <summary>درخواست</summary>
            Request = 3
            ''' <summary>ابطال</summary>
            Cancle = 4
        End Enum

        ''' <summary>انواع فاکتور انبار</summary>
        Public Enum TypeOfFactors
            ''' <summary>فاکتور خريد</summary>
            PurchaseInvoice = 1
            ''' <summary>فاکتور برگشت</summary>
            FactorBack = 2
        End Enum

        ''' <summary>تنظيمات اسپا سنتر</summary>
        Public Enum SpaSetting
            ''' <summary>مدت زمان اوليه آزاد(دقيقه)</summary>
            SpaenterTime = 1
            ''' <summary>مدت زمان اوليه ميهمانان(دقيقه)</summary>
            SpaEnterTimeGuest = 2
        End Enum

        ''' <summary>انواع صورتحساب ها</summary>
        Public Enum BillSubType
            ''' <summary>عمومي</summary>
            General = 1
            ''' <summary>قرارداد-مديران</summary>
            Contract_Management = 2
            ''' <summary>قرارداد-مراسم</summary>
            Contract_Ceremony = 3
            ''' <summary>قرارداد-کارکنان</summary>
            Contract_Personely = 4
            ''' <summary>پرسنلي</summary>
            Personely = 5
            ''' <summary>ستاد</summary>
            professor = 6
            ''' <summary>غذاي پرسنلي تالار</summary>
            PersonelyTalar = 7
            ''' <summary>سايرموارد</summary>
            Others = 8
            ''' <summary>شرکتي</summary>
            OtherContract = 9
            ''' <summary>موسسات</summary>
            Institute = 10
        End Enum

        ''' <summary>درگاه هاي پرداخت اينترنتي</summary>
        Public Enum InternetPaymentPorts
            ''' <summary>سامان</summary>
            Saman = 1
            ''' <summary>کشاورزي</summary>
            Keshavarzi = 2
            ''' <summary>اقتصاد نوين</summary>
            EghtesadNovin = 3
            ''' <summary>پارسيان</summary>
            Parsiyan = 4
            ''' <summary>صادرات</summary>
            Saderat = 5
            ''' <summary>ملي</summary>
            Melli = 6
            ''' <summary>ملت</summary>
            Mellat = 7
            ''' <summary>دي</summary>
            Dey = 8
            ''' <summary>فن آوا کارت</summary>
            FanAva = 9
            ''' <summary>مبناکارت</summary>
            Mabna = 10
            ''' <summary>پاسارگاد</summary>
            Pasargad = 11
            ''' <summary>ايران کيش</summary>
            IranKish = 12
        End Enum

        ''' <summary>سيستم هاي درخواست کننده PcPos</summary>
        Public Enum PcPosApplicantSystems
            ''' <summary>صورتحساب</summary>
            Bill = 1
            ''' <summary>اتاق هاي رجيسترکارت</summary>
            RegisterRoom = 2
            ''' <summary>پارکينگ</summary>
            Parking = 3
            ''' <summary>صندوق</summary>
            CashRegister = 4
        End Enum

        ''' <summary>نوع مرتب سازي</summary>
        Public Enum TypeOfSort
            ''' <summary>براساس ثبت کردن</summary>
            SortByRegister = 1
            ''' <summary>براساس کد</summary>
            SortByCode = 2
            ''' <summary>براساس عنوان</summary>
            SortByTitle = 3
        End Enum

        ''' <summary>وضعيت پرداخت PCPOS</summary>
        Public Enum PcPosPaymentStatus
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>آماده پرداخت</summary>
            ReadyPayment = 2
            ''' <summary>پرداخت شده</summary>
            Paymented = 3
            ''' <summary>قطعي</summary>
            Definite = 4
            ''' <summary>منقضي شده</summary>
            Expired = 5
            ''' <summary>غيرفعال</summary>
            DeActive = 6
        End Enum

        ''' <summary>انواع گروه بندي کالا</summary>
        Public Enum TypeOfGoods
            ''' <summary>کالاي انبار</summary>
            GoodOfStore = 1
            ''' <summary>گروه کالا</summary>
            GroupOfGood = 2
            ''' <summary>کالاي کاست کنترل</summary>
            GoodOfCostControl = 3
        End Enum

        ''' <summary>نحوه پرداخت جديد</summary>
        Public Enum NewPayType
            ''' <summary>هيچ</summary>
            None = 1
            ''' <summary>نقد</summary>
            Cash = 2
            ''' <summary>دستگاه Pos</summary>
            Pos = 3
            ''' <summary>فيش بانکي</summary>
            BankFish = 4
            ''' <summary>اينترنتي</summary>
            Enternet = 5
            ''' <summary>چک</summary>
            Cheque = 6
            ''' <summary>کارت به کارت</summary>
            CartToCart = 7
        End Enum

        ''' <summary>انواع صورت هاي مالي</summary>
        Public Enum FinancialStatementsTypes
            ''' <summary>ترازنامه</summary>
            BalanceSheets = 1
            ''' <summary>صورت سود و زيان</summary>
            ProfitAndLossStatement = 2
            ''' <summary>صورت جريان وجوه نقد</summary>
            CashFlowStatements = 3
            ''' <summary>صورت سود و زيان جامع</summary>
            ComprehensiveProfitAndLossAccount = 4
        End Enum

        ''' <summary>انواع ماهيت صورت هاي مالي</summary>
        Public Enum FinancialStatementsNature
            ''' <summary>افزاينده</summary>
            Incremental = 1
            ''' <summary>کاهنده</summary>
            Decremental = 2
            ''' <summary>دارايي</summary>
            Assets = 3
            ''' <summary>بدهي</summary>
            Liability = 4
            ''' <summary>حقوق مالک</summary>
            Owner 'sEquity=5
        End Enum

        ''' <summary>انواع مشخصه هاي سرشکن حساب ها</summary>
        Public Enum VariousTypesProrateAccount
            ''' <summary>حساب هاي مبداء</summary>
            SourceAccounts = 1
            ''' <summary>حساب هاي مقصد</summary>
            DestinationAccounts = 2
        End Enum

        ''' <summary>نحوه ي محاسبه سرشکن حسابها</summary>
        Public Enum CalculateAccounts
            ''' <summary>عملکرد</summary>
            Performance = 1
        End Enum

        ''' <summary>انواع وضعيت برگه هاي انبار</summary>
        Public Enum TypeOfStatusStoreDocument
            ''' <summary>قطعي</summary>
            Definite = 1
            ''' <summary>ابطال</summary>
            Cancel = 2
            ''' <summary>موقت</summary>
            Temporary = 3
            ''' <summary>Delete</summary>
            Delete = 4
            ''' <summary>قابل ويرايش</summary>
            Editable = 5
            ''' <summary>ريالي بدون مبلغ</summary>
            NoPrice = 6
        End Enum

        ''' <summary>وضعيت نامه</summary>
        Public Enum LetterStatus
            ''' <summary>درگردش</summary>
            InReferral = 170
            ''' <summary>مينوت</summary>
            Draft = 170
            ''' <summary>ثبت شده</summary>
            Saved = 170
        End Enum

        ''' <summary>سوابق پرسنل</summary>
        Public Enum PeopleHistory
            ''' <summary>سابقه سنوات</summary>
            SanavatHistory = 1
            ''' <summary>ارزيابي سالانه</summary>
            YearlyEvaluation = 2
            ''' <summary>انقطاع خدمت</summary>
            DisEmployee = 3
            ''' <summary>دوره هاي آموزشي</summary>
            EducationalCourse = 4
            ''' <summary>خارج سازمان</summary>
            ExternalEmployee = 5
            ''' <summary>سابقه سربازي</summary>
            MiliarityHistory = 6
            ''' <summary>مدارک تحصيلي</summary>
            StudyHistory = 7
            ''' <summary>سوابق جذب</summary>
            AbsorbScore = 8
            ''' <summary>سوابق گروه پرسنل</summary>
            GradeHistory = 9
            ''' <summary>کارانه</summary>
            Efficiency = 10
            ''' <summary>بسيج</summary>
            Mobilization = 11
            ''' <summary>سوابق تنبيهات</summary>
            Grueling = 12
            ''' <summary>سوابق تشويقات</summary>
            encouragement = 13
        End Enum

        ''' <summary>مقاطع تحصيلي</summary>
        Public Enum StudyLevel
            ''' <summary>ديپلم</summary>
            Diplom = 1
            ''' <summary>فوق ديپلم</summary>
            ExtraDiplom = 2
            ''' <summary>ليسانس</summary>
            Lisance = 3
            ''' <summary>فوق ليسانس</summary>
            ExtraLisance = 4
            ''' <summary>دکترا</summary>
            doctora = 5
        End Enum

        ''' <summary>درجه نياز</summary>
        Public Enum NecessaryDegree
            ''' <summary>درجه نياز 1</summary>
            Necessary1 = 1
            ''' <summary>درجه نياز 2</summary>
            Necessary2 = 2
            ''' <summary>درجه نياز 3</summary>
            Necessary3 = 3
            ''' <summary>درجه نياز 4</summary>
            Necessary4 = 4
        End Enum

        ''' <summary>نوع قرارداد رزرو خدمات</summary>
        Public Enum ContractTypeReserve
            ''' <summary>قرارداد شخصي</summary>
            PersonContract = 1
            ''' <summary>قرارداد شرکتي</summary>
            SocietyContract = 2
        End Enum

        ''' <summary>نوع فرمول حکم</summary>
        Public Enum PrescriptionFormulaType
            ''' <summary>ورود اطلاعات</summary>
            EnteringData = 1
            ''' <summary>محاسباتي</summary>
            Calculating = 2
        End Enum

        ''' <summary>گروه بندي اطلاعات حکم</summary>
        Public Enum PrescriptionFormulaGroups
            ''' <summary>سوابق</summary>
            History = 1
            ''' <summary>امتيازات</summary>
            Point = 2
            ''' <summary>حقوق</summary>
            Salary = 3
        End Enum

        ''' <summary>سيستم</summary>
        Public Enum SubSystem
            ''' <summary>سيستم احکام</summary>
            PrescriptionsSystem = 1
            ''' <summary>سيستم حقوق و دستمزد</summary>
            SalarySystem = 2
        End Enum

        ''' <summary>کيفيت آموزشي</summary>
        Public Enum EducationQuality
            ''' <summary>نياز يک</summary>
            Necc1 = 1
            ''' <summary>نياز دو</summary>
            Necc2 = 2
            ''' <summary>خوب</summary>
            Good = 3
            ''' <summary>خيلي خوب</summary>
            VeryGood = 4
        End Enum

        ''' <summary>نوع پرسنل</summary>
        Public Enum PERSONNEL_TYPE
            ''' <summary>کارگر</summary>
            Worker = 1
            ''' <summary>کارمند</summary>
            Personnel = 2
            ''' <summary>قراردادي</summary>
            Contract = 3
        End Enum

        ''' <summary>زبان اصلي</summary>
        Public Enum MainLaguage
            ''' <summary>زبان اصلي فرانسه - انگليسي</summary>
            Main = 1
            ''' <summary>ساير زبانها</summary>
            Other = 2
        End Enum

        ''' <summary>بخش شغلي</summary>
        Public Enum Job_Section
            ''' <summary>درگردش</summary>
            InReferral = 170
            ''' <summary>10000</summary>
            Section10000 = 181
            ''' <summary>20000</summary>
            Section20000 = 181
            ''' <summary>30000</summary>
            Section30000 = 181
            ''' <summary>40000</summary>
            Section40000 = 181
            ''' <summary>50000</summary>
            Section50000 = 181
            ''' <summary>60000</summary>
            Section60000 = 181
            ''' <summary>80000</summary>
            Section80000 = 181
        End Enum

        ''' <summary>درجه تسلط</summary>
        Public Enum GripeDegree
            ''' <summary>آشنايي کافي</summary>
            Enough = 182
            ''' <summary>آشنايي کامل</summary>
            Complete = 182
            ''' <summary>خوب</summary>
            Good = 182
        End Enum

        ''' <summary>نوع عملکرد مشترکين</summary>
        Public Enum Subscribe_Operation_Type
            ''' <summary>اول دوره</summary>
            Primery = 1
            ''' <summary>کسب شده</summary>
            Earned = 2
            ''' <summary>استفاده شده</summary>
            Used = 3
            ''' <summary>افزايش امتياز</summary>
            Increase = 4
            ''' <summary>کاهش امتياز</summary>
            Decrease = 5
        End Enum

        ''' <summary>نوع استخدام پرسنل</summary>
        Public Enum PeopleEmploymentType
            ''' <summary>کارگر</summary>
            Worker = 1
            ''' <summary>کارمند</summary>
            Employee = 184
            ''' <summary>قراردادي</summary>
            Contract = 3
        End Enum

        ''' <summary>وضعيت تاهل</summary>
        Public Enum MaritalStatus
            ''' <summary>مجرد</summary>
            _SINGLE = 1
            ''' <summary>متاهل</summary>
            MARRIAGE = 2
            ''' <summary>متارکه</summary>
            DIVORCE = 3
        End Enum

        ''' <summary>نوع ورود اطلاعات کدينگ</summary>
        Public Enum AccountItemType
            ''' <summary>ورود داده</summary>
            EnterringData = 1
            ''' <summary>سيستمي</summary>
            System = 2
        End Enum

        ''' <summary>پارامترهاي متغير سيستمي احکام</summary>
        Public Enum PrescriptionParameterSystem
            ''' <summary>دامنه امتيازات سنوات خدمت </summary>
            LaborCode = 1
            ''' <summary>امتياز شغلي</summary>
            JobPointSystem = 2
        End Enum

        ''' <summary>جداول سيستمي مالي</summary>
        Public Enum AccountTableSystems
            ''' <summary>پرسنلي</summary>
            PERSONNEL = 1
            ''' <summary>شرکتي</summary>
            CONTRACT = 2
            ''' <summary>انبارها</summary>
            STORE = 3
            ''' <summary>آژانس ها</summary>
            Agency = 4
            ''' <summary>فروشندگان</summary>
            Seller = 5
            ''' <summary>صندوق - موجودي اول دوره</summary>
            ImprestInitBalance = 7
            ''' <summary>تنخواه - موجودي اول دوره</summary>
            CashInitBalance = 8
            ''' <summary>بانک -موجودي اول دوره</summary>
            BankInitBalance = 6
        End Enum

        ''' <summary>انواع آيتم هاي خزانه داري</summary>
        Public Enum BursaryType
            ''' <summary>چک</summary>
            Cheques = 1
            ''' <summary>انتظامي</summary>
            Discipline = 4
            ''' <summary>حواله</summary>
            Assignment = 5
            ''' <summary>هزينه </summary>
            Cost = 6
            ''' <summary>درآمد</summary>
            Income = 7
            ''' <summary>سود بانکي</summary>
            BenefitBank = 9
            ''' <summary>فيش نقدي</summary>
            MoneyFish = 8
            ''' <summary>دستگاه Pos</summary>
            Pos = 5
            ''' <summary>قبوض</summary>
            Bills = 6
            ''' <summary>سفته</summary>
            Paper = 7
            ''' <summary>اوراق بهادار</summary>
            PortFolio = 8
        End Enum

        ''' <summary>انواع کدينگهاي بانک</summary>
        Public Enum BankAccountCode
            ''' <summary>حساب اصلي بانک</summary>
            Bank = 1
            ''' <summary>اسناد پرداختني</summary>
            Pay = 2
            ''' <summary>اسناد دريافتني</summary>
            Recieve = 3
        End Enum

        ''' <summary>انواع مشخصه هاي کالا</summary>
        Public Enum GoodProperties
            ''' <summary>واحد فرعي</summary>
            SecondaryUnit = 1
            ''' <summary>برند</summary>
            Brand = 2
            ''' <summary>ارتباط کالاي کاست و انبار</summary>
            CostRelationToGood = 3
        End Enum

        ''' <summary>انواع استهلاک گيري</summary>
        Public Enum PossessionWearOffType
            ''' <summary>مستقيم</summary>
            Direct = 1
            ''' <summary>نزولي</summary>
            Descending = 2
        End Enum

        ''' <summary>انواع اموال</summary>
        Public Enum PossessionType
            ''' <summary>اموال</summary>
            Possession = 1
            ''' <summary>ابزار</summary>
            Tools = 2
            ''' <summary>اموال مصرفي</summary>
            Consumable = 3
        End Enum

        ''' <summary>انواع وضعيت اموال</summary>
        Public Enum PossessionStatus
            ''' <summary>فعال</summary>
            Active = 1
            ''' <summary>اسقاط</summary>
            Escape = 2
            ''' <summary>مفقود</summary>
            Lost = 3
        End Enum

        ''' <summary>انواع دليل استهلاک اموال</summary>
        Public Enum PossessionWearOffReason
            ''' <summary>استهلاک ساليانه</summary>
            Yearly = 1
            ''' <summary>اسقاط</summary>
            Escape = 2
            ''' <summary>برکناري</summary>
            Dismiss = 3
            ''' <summary>مفقودي</summary>
            Lost = 4
            ''' <summary>ماهيانه</summary>
            Monthly = 5
        End Enum

        ''' <summary>انواع وابستگي فهرست بها</summary>
        Public Enum PriceListDependencyType
            ''' <summary>درصدي</summary>
            Percenty = 1
            ''' <summary>تفاوت قيمت</summary>
            Price = 2
            ''' <summary>فرمول</summary>
            Formula = 3
        End Enum

        ''' <summary>موجودي اول دوره خزانه داري</summary>
        Public Enum AccountInitialBalanceType
            ''' <summary>بانک</summary>
            Bank = 1
            ''' <summary>تنخواه</summary>
            Imprest = 2
            ''' <summary>صندوق</summary>
            Cash = 3
        End Enum

        ''' <summary>نوع قيمت گذاري اسناد انبار</summary>
        Public Enum StoreDocumentPriceingTypes
            ''' <summary>ميانگين</summary>
            Average = 1
            ''' <summary>ثابت</summary>
            Fixed = 2
            ''' <summary>آخرين قيمت خريد</summary>
            LastPurchasePrice = 3
            ''' <summary>فهرست بها</summary>
            PriceList = 4
        End Enum

        ''' <summary>انواع پاسخ</summary>
        Public Enum ResponseType
            ''' <summary>Selectي</summary>
            Selective = 8
            ''' <summary>تشريحي</summary>
            Anatomical = 8
        End Enum

        ''' <summary>نوع پاسخ Selectي</summary>
        Public Enum SelectiveResponseType
            ''' <summary>يکتا-کشويي</summary>
            Unique_Combo = 8
            ''' <summary>چندگانه-چک ليست</summary>
            Multiple_Checklist = 8
            ''' <summary>يکتا-دکمه راديويي</summary>
            Unique_Radio = 8
        End Enum

        ''' <summary>نوع فرم</summary>
        Public Enum FormType
            ''' <summary>نظرسنجي</summary>
            Survey = 8
            ''' <summary>شکايت</summary>
            Complaint = 8
            ''' <summary>چک ليست</summary>
            CheckList = 8
        End Enum

        ''' <summary>مخاطب</summary>
        Public Enum Audiance
            ''' <summary>ميهمان غيرمقيم</summary>
            Guest_NoneResiding = 1
            ''' <summary>پرسنل</summary>
            People = 8
            ''' <summary>متفرقه</summary>
            Other = 8
            ''' <summary>ميهمان مقيم</summary>
            Guest_Residing = 4
            ''' <summary>آژانس ها</summary>
            Contractors = 9
        End Enum

        ''' <summary>انواع نحوه صدور سند</summary>
        Public Enum TypesOfDocumentIssuance
            ''' <summary>به تفکيک</summary>
            Divided = 1
            ''' <summary>سرجمع </summary>
            GROUPED = 2
        End Enum

        ''' <summary>انواع اطلاعات در شرح سند انبار</summary>
        Public Enum FieldsOfStoreVoucher
            ''' <summary>شماره سند </summary>
            StoreDocumentCode = 1
            ''' <summary>تاريخ سند </summary>
            StoreDocumentDate = 2
            ''' <summary>نوع سند</summary>
            StoreDocumentType = 3
            ''' <summary>عنوان انبار</summary>
            StoreTitle = 4
            ''' <summary>عنوان گروه کالا</summary>
            GoodTypeTitle = 5
            ''' <summary>عنوان کالا</summary>
            GoodTitle = 6
            ''' <summary>شماره فاکتور</summary>
            FactorCode = 7
            ''' <summary>تاريخ فاکتور</summary>
            FactorDate = 8
            ''' <summary>محل مصرف</summary>
            ConsumePlace = 9
            ''' <summary>نام فروشنده</summary>
            SellerName = 10
            ''' <summary>نوع سند مرتبط</summary>
            ParentStoreDocumentCode = 11
            ''' <summary>تاريخ سند مرتبط</summary>
            ParentStoreDocumentDate = 12
            ''' <summary>شماره سند مرتبط</summary>
            ParentStoreDocumentType = 13
            ''' <summary>نام تنخواه دار</summary>
            BuyerName = 14
            ''' <summary>عنوان کد مالي</summary>
            AccTitle = 14
        End Enum

        ''' <summary>انواع شرح اسناد انبار</summary>
        Public Enum StoreVoucherTemplates
            ''' <summary>طرف بدهکار رسيد</summary>
            ReceiptDebit = 1
            ''' <summary>طرف بستانکار فروشنده</summary>
            ReceiptCellerCredit = 2
            ''' <summary>طرف بستانکار تنخواه دار</summary>
            ReceiptBuyerCredit = 3
            ''' <summary>طرف بدهکار تنخواه دار</summary>
            ReceiptBuyerDebit = 4
        End Enum

        ''' <summary>نوع داده پاسخ تشريحي</summary>
        Public Enum ResponseDescType
            ''' <summary>عددي</summary>
            Numeric = 1
            ''' <summary>متن-تک خطي</summary>
            Text_OnlyLine = 1
            ''' <summary>متن-چند خطي</summary>
            Text_MultiLine = 1
        End Enum

        ''' <summary>انواع نگهداري تجهيز</summary>
        Public Enum MaintenanceTypes
            ''' <summary>سرويس</summary>
            Service = 1
            ''' <summary>تعويض</summary>
            Change = 2
            ''' <summary>بازديد</summary>
            Visit = 3
            ''' <summary>چک ليست</summary>
            CheckList = 4
        End Enum

        ''' <summary>انواع دوره نگهداري</summary>
        Public Enum DurationTypes
            ''' <summary>کارکرد</summary>
            Functional = 1
            ''' <summary>ساعتي</summary>
            Hourly = 2
            ''' <summary>روزانه</summary>
            Daily = 3
        End Enum

        ''' <summary>نوع ثبت رسيد</summary>
        Public Enum ReceiptType
            ''' <summary>ثبت ريالي رسيد </summary>
            PriceType = 1
            ''' <summary>ثبت مقداري رسيد</summary>
            ValueType = 2
            ''' <summary>ثبت مقداري/ريالي رسيد</summary>
            PriceValueTtpe = 3
        End Enum

        ''' <summary>انواع فصل</summary>
        Public Enum SeasonType
            ''' <summary>L</summary>
            L = 1
            ''' <summary>H</summary>
            H = 2
            ''' <summary>S</summary>
            S = 3
            ''' <summary>HP</summary>
            HP = 4
        End Enum

        ''' <summary>انواع مشخصه هاي اتاق هاي رجيستر شده</summary>
        Public Enum RegisterRoomProperty
            ''' <summary>درخواست مزاحم نشويد</summary>
            DoNotDisturb = 1
            ''' <summary>پايان درخواست مزاحم نشويد</summary>
            EndOfDoNotDisturb = 2
            ''' <summary>درخواست نظافت</summary>
            CleanUpRoom = 3
            ''' <summary>پايان درخواست نظافت</summary>
            EndOfCleanUpRoom = 4
            ''' <summary>درخواست لاندري</summary>
            Landry = 5
            ''' <summary>پايان درخواست لاندري</summary>
            EndOfLandry = 6
            ''' <summary>توضيحات تخليه رجيسترکارت</summary>
            CheckoutDescription = 7
        End Enum

        ''' <summary>وضعيت درخواست</summary>
        Public Enum ServiceRequestStatus
            ''' <summary>درحال اجرا</summary>
            InProcess = 1
            ''' <summary>اجرا شده</summary>
            Done = 2
            ''' <summary>صدور</summary>
            IssueServiceRequest = 3
            ''' <summary>تاييد</summary>
            Confirm = 4
            ''' <summary>برنامه ريزي و اجرا</summary>
            Planning = 5
            ''' <summary>پايان</summary>
            EndOfServiceRequest = 6
        End Enum

        ''' <summary>تنظيمات اندازه رک</summary>
        Public Enum RackSizeSetting
            ''' <summary>اندازه فرم</summary>
            FormSize = 2
            ''' <summary>سلولهاي رک</summary>
            CelSize = 3
            ''' <summary>تصوير اتاق</summary>
            RoomImage = 4
            ''' <summary>آرم شرکت</summary>
            Contractor = 5
            ''' <summary>پيغام</summary>
            Message = 6
            ''' <summary>يادداشتها</summary>
            Notification = 7
            ''' <summary>صورتحساب باز</summary>
            OpenBill = 8
            ''' <summary>Vip</summary>
            Vip = 9
        End Enum

        ''' <summary>انواع Recipe </summary>
        Public Enum RecipiTypes
            ''' <summary>رستوران</summary>
            Resturent = 1
            ''' <summary>تالار</summary>
            Talar = 2
            ''' <summary>کافي شاپ</summary>
            Teria = 3
            ''' <summary>لاندري</summary>
            Landry = 4
        End Enum

        ''' <summary>انواع وضعيت Exit کالا و اموال</summary>
        Public Enum GoodExitStatus
            ''' <summary>خارج شده</summary>
            Exited = 1
            ''' <summary>تحويل داده شده</summary>
            Returned = 2
            ''' <summary>Delete شده</summary>
            Deleted = 3
        End Enum

        ''' <summary>غذا و نوشابه</summary>
        Public Enum CostFood
            ''' <summary>رستوران ها</summary>
            Restaurant = 1
            ''' <summary>آشپزخانه ها</summary>
            Kitchen = 3
        End Enum

        ''' <summary>تريا</summary>
        Public Enum CostTeria
            ''' <summary>کافي شاپ ها</summary>
            CaffeShop = 2
        End Enum


    End Class
    Public Class Keys

        Public Enum PeopleType
            ''' <summary>پرسنل</summary>
            Personel = 2
            ''' <summary>درخواست کننده</summary>
            REQUESTER = 3
            ''' <summary>کارفرما</summary>
            EMPLOYER = 4
        End Enum

        ''' <summary>مرجع قيمتها در شارژ</summary>
        Public Enum CostReferenceType
            ''' <summary>فهرست بها</summary>
            PriceList = 1031
            ''' <summary>قيمت مشخص</summary>
            Definite = 1032
        End Enum



        ''' <summary>جنسيت</summary>
        Public Enum Gender
            ''' <summary>مرد</summary>
            Male = 1081
            ''' <summary>زن</summary>
            Female = 1082
        End Enum


        ''' <summary>انواع دسته بن</summary>
        Public Enum BillSerialType
            ''' <summary>رجيسترکارت</summary>
            RegisterCard = 1101
            ''' <summary>رزرو</summary>
            Reserve = 1102
            ''' <summary>صورتحساب</summary>
            Bill = 1103
            ''' <summary>رزرو خدمات</summary>
            ReserveServices = 1104
            ''' <summary>اسپا سنتر</summary>
            SpaCenter = 1105
            ''' <summary>ليست انتظار</summary>
            WaitingList = 1106
        End Enum

        ''' <summary>وضعيتهاي رجيسترکارت</summary>
        Public Enum RegisterStatus
            ''' <summary>موقت</summary>
            Temporary = 1110
            ''' <summary>فعال</summary>
            Active = 1111
            ''' <summary>تخليه شده</summary>
            Checkout = 1112
            ''' <summary>تسويه</summary>
            PayOff = 1113
            ''' <summary>ابطال</summary>
            Cancel = 1119
        End Enum

        ''' <summary>وضعيتهاي اتاقهاي رجيسترکارت</summary>
        Public Enum RegisterRoomStatus
            ''' <summary>موقت</summary>
            Temporary = 1120
            ''' <summary>فعال</summary>
            Active = 1121
            ''' <summary>تخليه شده</summary>
            Checkout = 1122
            ''' <summary>تسويه</summary>
            PayOff = 1123
            ''' <summary>تعويض شده</summary>
            Change = 1124
            ''' <summary>تغيير نوع</summary>
            ChangeType = 1125
            ''' <summary>ابطال</summary>
            Cancel = 1129
        End Enum

        ''' <summary>وضعيتهاي اتاق مهمانان رجيسترکارت</summary>
        Public Enum RegisterRoomGuestStatus
            ''' <summary>موقت</summary>
            Temporary = 1130
            ''' <summary>فعال</summary>
            Active = 1131
            ''' <summary>خارج شده</summary>
            Checkout = 1132
            ''' <summary>تعويض شده</summary>
            Change = 1133
            ''' <summary>تغيير نوع</summary>
            ChangeType = 1134
            ''' <summary>ابطال</summary>
            Cancel = 1139
        End Enum

        ''' <summary>وضعيتهاي مهمانان رجيسترکارت</summary>
        Public Enum RegisterGuestStatus
            ''' <summary>موقت</summary>
            Temporary = 1140
            ''' <summary>فعال</summary>
            Active = 1141
            ''' <summary>خارج شده</summary>
            Checkout = 1142
            ''' <summary>ابطال</summary>
            Cancel = 1149
        End Enum

        ''' <summary>وضعيتها</summary>
        Public Enum Status
            ''' <summary>غيرفعال</summary>
            DeActive = 1150
            ''' <summary>فعال</summary>
            Active = 1151
            ''' <summary>در حال گردش</summary>
            Flow = 1152
            ''' <summary>پايان گردش</summary>
            EndProcess = 1153
            ''' <summary>قطعي</summary>
            Definite = 1154
            ''' <summary>ابطال</summary>
            Cancel = 1159
            ''' <summary>بسته شده</summary>
            Closed = 1160
            ''' <summary>موقت</summary>
            Temporary = 1161
        End Enum

        ''' <summary>انواع مهمانان رجيستر</summary>
        Public Enum RegisterGuestType
            ''' <summary>عادي</summary>
            Normal = 1162
            ''' <summary>اضافه تمام بها</summary>
            ExtraFull = 1163
            ''' <summary>اضافه نيمه بها</summary>
            ExtraHalf = 1164
            ''' <summary>زير سن محاسبه</summary>
            NotAccounting = 1165
        End Enum

        ''' <summary>انواع شرکتها</summary>
        Public Enum ContractorType
            ''' <summary>مهمان</summary>
            Guest = 1171
            ''' <summary>حقيقي</summary>
            Personal = 1172
            ''' <summary>حقوقي</summary>
            Company = 1173
            ''' <summary>فروشنده</summary>
            Seller = 1174
            ''' <summary>مالک</summary>
            Owner = 1175
            ''' <summary>پيمانکار</summary>
            Contractor = 1176
        End Enum

        ''' <summary>نحوه پرداخت</summary>
        Public Enum PayType
            ''' <summary>نقدي</summary>
            Cash = 1181
            ''' <summary>دستگاه Pos</summary>
            Pos = 1182
            ''' <summary>فيش بانکي</summary>
            BankFish = 1183
            ''' <summary>اتاق</summary>
            Room = 1184
            ''' <summary>اتاق قراردادي</summary>
            RoomContract = 1185
            ''' <summary>قرارداد</summary>
            Contract = 1186
            ''' <summary>پرسنل</summary>
            Personel = 1187
            ''' <summary>رايگان</summary>
            Free = 1188
            ''' <summary>نقد+Pos</summary>
            PosCash = 1189
            ''' <summary>اينترنتي</summary>
            Enternet = 1190
            ''' <summary>رزرو</summary>
            Reserve = 2300
            ''' <summary>هزينه</summary>
            Cost = 2301
            ''' <summary>چک</summary>
            CHEQUES = 2302
        End Enum

        ''' <summary>نوع سرويس رستوران</summary>
        Public Enum FoodServiceType
            ''' <summary>محل</summary>
            Local = 1191
            ''' <summary>اتاق</summary>
            RoomService = 1192
            ''' <summary>ساير</summary>
            Other = 1193
            ''' <summary>بيرون بر</summary>
            Export = 1194
            ''' <summary>سرويس VIP</summary>
            VIP = 1195
            ''' <summary>مراسم</summary>
            ceremony = 1196
            ''' <summary>سرويس متفرقه</summary>
            EtcService = 1197
        End Enum

        ''' <summary>وضعيت صورتحسابها</summary>
        Public Enum BillStatus
            ''' <summary>باز</summary>
            Temporary = 1200
            ''' <summary>بسته</summary>
            Definite = 1202
            ''' <summary>ابطال</summary>
            Cancel = 1209
        End Enum

        ''' <summary>انواع سرويس ها</summary>
        Public Enum ServiceType
            ''' <summary>غذاها</summary>
            Food = 1211
            ''' <summary>سرويس</summary>
            Service = 1212
            ''' <summary>لباس</summary>
            Landry = 1213
            ''' <summary>کالاي فروشگاه</summary>
            ShopGood = 1214
            ''' <summary>ملزومات اتاق</summary>
            RoomSupplies = 1215
            ''' <summary>خسارت</summary>
            Damage = 1216
            ''' <summary>انواع خدمات</summary>
            ServiceType = 1217
        End Enum

        ''' <summary>انواع خصوصيات رجيستر</summary>
        Public Enum RegisterPropertyType
            ''' <summary>قرارداد</summary>
            Contract = 1221
            ''' <summary>پيغام</summary>
            Message = 1222
            ''' <summary>يادداشت</summary>
            Notification = 1223
            ''' <summary>شارژاتاق</summary>
            RoomCharge = 1224
            ''' <summary>سوابق مدت اقامت</summary>
            ResidentTimeHistory = 1225
            ''' <summary>نوع Vip</summary>
            VipType = 1226
            ''' <summary>شماره چاپ صورتحساب رجيستر</summary>
            BillPrintNo = 1227
            ''' <summary>اضافه شارژ اتاق</summary>
            DailyUse = 1228
            ''' <summary>استفاده از قرار داد گارانتي</summary>
            UseFromGuaranteeContract = 1229
            ''' <summary>شماره سريال صورتحساب فروش</summary>
            SerialNoSaleBill = 1230
            ''' <summary>معرف</summary>
            Presenter = 4520
        End Enum

        ''' <summary>انواع خصوصيات افراد</summary>
        Public Enum PeoplePropertyType
            ''' <summary>پرسنل</summary>
            Personel = 1231
            ''' <summary>معرف</summary>
            Presenter = 1232
            ''' <summary>واحد رزرو</summary>
            ReserveUnit = 1233
            ''' <summary>پشتيبان</summary>
            Supporter = 1234
            ''' <summary>ليست سياه</summary>
            BlackList = 1235
            ''' <summary>ميزبان</summary>
            Host = 1236
            ''' <summary>راننده</summary>
            Driver = 1237
            ''' <summary>تخفيف پرسنل</summary>
            PersonelDiscount = 1238
            ''' <summary>مامور خريد</summary>
            PurchasingOfficer = 1239
            ''' <summary>کد مالي پرسنل</summary>
            AccountCode = 1240
            ''' <summary>کدينگ مالي مامور خريد</summary>
            AccCodePurchasingOfficer = 2922
            ''' <summary>کفالت احکام</summary>
            AgreementBail = 2923
            ''' <summary>کفالت درمان</summary>
            TreatmentBail = 2924
            ''' <summary>ثبات</summary>
            Registrar = 2925
        End Enum

        ''' <summary>تنظيمات</summary>
        Public Enum Setting
            ''' <summary>تنظيمات شارژ</summary>
            ChargeSetting = 26
            ''' <summary>تنظيمات رک</summary>
            RackSetting = 27
            ''' <summary>تنظيمات رستوران</summary>
            RestaurantSetting = 28
            ''' <summary>تنظيمات تريا</summary>
            TeriaSetting = 29
            ''' <summary>تنظيمات رجيستر کارت</summary>
            RegisterSetting = 30
            ''' <summary>تنظيمات مشترکين</summary>
            SubscribSetting = 31
            ''' <summary>ساير تنظيمات</summary>
            OtherSetting = 32
            ''' <summary>تنظيمات صورتحساب</summary>
            GustBillSetting = 33
            ''' <summary>تنضيمات رزرو</summary>
            ReserveSetting = 34
            ''' <summary>تنظيمات پيامک</summary>
            SmsSetting = 35
            ''' <summary>تنظيمات کد حساب سند حسابداري</summary>
            AccountCodeSetting = 37
            ''' <summary>تنظيمات لاندري</summary>
            LandrySetting = 38
            ''' <summary>تنظيمات ايميل</summary>
            EmailSetting = 39
            ''' <summary>تنظيمات فروشگاه</summary>
            ShopSetting = 40
            ''' <summary>تنظيمات خانه داري</summary>
            RoomKeepingSetting = 41
            ''' <summary>تنظيمات رزرو خدمات</summary>
            ServiceReserveSetting = 42
            ''' <summary>تنظيمات پيام صوتي</summary>
            AudioMessageSetting = 132
            ''' <summary>تنظيمات انبار و کاست کنترل</summary>
            StoreAndCostControlSetting = 133
            ''' <summary>تنظيمات PC POS</summary>
            PcPosSetting = 136
            ''' <summary>تنظيمات اسپا سنتر</summary>
            SpaSetting = 157
        End Enum

        ''' <summary>تنظيمات شارژ</summary>
        Public Enum ChargeSetting
            ''' <summary>انواع شب رايگان</summary>
            FreeDayType = 215
            ''' <summary>ساعت شارژ</summary>
            ChargeTime = 1241
            ''' <summary>ساعت شارژ شب قبل</summary>
            LastNightChargeTime = 1242
            ''' <summary>ساعت اضافه شارژ اول</summary>
            DailyUseTimeFirst = 1243
            ''' <summary>ساعت اضافه شارژ دوم</summary>
            DailyUseTimeSecond = 1244
            ''' <summary>درصد اضافه شارژ اول</summary>
            DailyUsePercentFirst = 1245
            ''' <summary>درصد اضافه شارژ دوم</summary>
            DailyUsePercentSecond = 1246
            ''' <summary>حدقل سن محاسبه</summary>
            AccountingAge = 1247
            ''' <summary>سن محاسبه نيمه بها</summary>
            HalfAccountingAge = 1248
            ''' <summary>محاسبه اضافه شارژ بر اساس فهرست بها</summary>
            DailyUseByPriceList = 1249
            ''' <summary>شارژ گارانتي</summary>
            GuaranteeCharge = 1250
            ''' <summary>شارژ مانده گارانتي</summary>
            ChargeRemainGuarantee = 2440
            ''' <summary>شارژ صبحانه بر مبناي ظرفيت اتاق</summary>
            ChargeBasedRoomCapacity = 2441
            ''' <summary>محاسبه تخفيف صبحانه شارژ</summary>
            ComputeBreakfastDiscount = 2442
            ''' <summary>ساعت اضافه شارژ اول مشترکين</summary>
            DailyUseTimeFirstSubscribe = 2443
            ''' <summary>ساعت اضافه شارژ دوم مشترکين</summary>
            DailyUseTimeSecondSubscribe = 2444
            ''' <summary>محاسبات براساس پکيج</summary>
            PackageCalculating = 2445
            ''' <summary>فعال سازي جريمه Exit زود هنگام</summary>
            ActiveRoomChargeExitEarly = 2446
            ''' <summary>اعمال شارژ شب قبل به روز گذشته</summary>
            LastNightChargePreDate = 2447
            ''' <summary>درصد شارژ ورود زود هنگام</summary>
            EarlyArrivalChargePercent = 2448
            ''' <summary>ساعت شروع پذيرش</summary>
            ReceptionStartTime = 2449
            ''' <summary>فعال سازي شارژ تاخير در ورود</summary>
            ActiveRoomChargeArrivalDelay = 2450
        End Enum

        ''' <summary>تنظيمات رک</summary>
        Public Enum RackSetting
            ''' <summary>نمايش Header در رک</summary>
            RackHeader = 1251
            ''' <summary>غير فعال نشدن رک</summary>
            NotDisable = 1252
        End Enum

        ''' <summary>تنظيمات رستوران</summary>
        Public Enum RestaurantSetting
            ''' <summary>جاپ برگه آشپزخانه رستوران پس از ثبت صورتحساب</summary>
            KitchenPrint = 1261
            ''' <summary>سوال کردن جهت جاپ برگه آشپزخانه رستوران پس از ثبت صورتحساب</summary>
            QuestionForPrint = 1262
            ''' <summary>جاپ برگه سرويس اتاق پس از ثبت صورتحساب</summary>
            ServicePrint = 1263
            ''' <summary>چاپ دسر خوري</summary>
            DesertPrint = 1264
            ''' <summary>درصد سرويس اتاق</summary>
            RoomServicePercent = 1265
            ''' <summary>چاپ برگه حسابداري رستوران</summary>
            FinancialPrint = 1266
            ''' <summary>چاپ برگه مشتري</summary>
            IsPrintCustomerCash = 1267
            ''' <summary>نوع برگه صندوق</summary>
            CashPageType = 1268
            ''' <summary>درصد سرويس محل</summary>
            LocalServicePercent = 1269
            ''' <summary>درصد ساير سرويسها</summary>
            OtherServicePercent = 1270
            ''' <summary>عدم محاسبه ماليات رستوران</summary>
            NotDuty = 1271
            ''' <summary>درصد سرويس بيرون بر</summary>
            ExportServicePercent = 1272
            ''' <summary>رستوران بن هاي نهار و شام ثبت شده در صندوق</summary>
            LunchResturantDefualt = 1273
            ''' <summary>رستوران بن هاي صبحانه ثبت شده در صندوق</summary>
            BerekResturantDefualt = 1274
            ''' <summary>صدور بن بر اساس منوي غذاي</summary>
            HasFoodMenu = 1275
            ''' <summary>پيغام زير صورتحساب رستوران </summary>
            ResturantBillFooterMessage = 1276
            ''' <summary>چاپ برگه صندوق</summary>
            ResturantBillPrint = 1277
            ''' <summary>تعداد چاپ برگه صندوق</summary>
            ResturantBillPrintCount = 1278
            ''' <summary>جاپ برگه آشپزخانه گروههاي غذاي غير اصلي</summary>
            KitchenPrintForNotMain = 1279
            ''' <summary>درصد سرويس مراسم</summary>
            ceremony = 1280
            ''' <summary>درصد سرويس Vip</summary>
            VIP = 3070
            ''' <summary>استفاده از حق سرويس در رستوران جديد</summary>
            UseServiceInNewResturant = 3071
            ''' <summary>استفاده از ماليت  در رستوران جديد</summary>
            UseDutyInNewResturant = 3072
            ''' <summary>فعال بودن تخفيف در رستوران جديد</summary>
            EnableDiscountInNewResturant = 3073
            ''' <summary>تخفيف تمام آيتمهاي فاکتور رستوران</summary>
            DisForAllItemInFactorResturant = 3074
            ''' <summary>عدم چاپ رمز اينترنت</summary>
            DontPrintPasswordOfInternetRestaurant = 3075
            ''' <summary>امکان بستن بن با صندوق روز گذشته</summary>
            DefiniteBillByYesterdayShift = 3076
            ''' <summary>نمايش مبلغ در برگه آشپزخانه</summary>
            ShowPriceKitchenPrint = 3077
            ''' <summary>عدم چاپ بن پرسنلي</summary>
            NotPrintPersonelBill = 3078
        End Enum

        ''' <summary>تنظيمات تريا</summary>
        Public Enum TeriaSetting
            ''' <summary>جاپ برگه آشپزخانه تريا پس از ثبت صورتحساب</summary>
            KitchenPrint = 1281
            ''' <summary>سوال کردن جهت جاپ برگه آشپزخانه تريا پس از ثبت صورتحساب</summary>
            QuestionForPrint = 1282
            ''' <summary>چاپ برگه حسابداري تريا</summary>
            FinancialPrint = 1283
            ''' <summary>چاپ برگه مشتري</summary>
            IsPrintCustomerCash = 1284
            ''' <summary>نوع برگه صندوق</summary>
            CashPageType = 1285
            ''' <summary>عدم محاسبه ماليات تريا</summary>
            NotDuty = 1286
            ''' <summary>پيغام زير صورتحساب تريا </summary>
            TeriaBillFooterMessage = 1287
            ''' <summary>چاپ برگه صندوق</summary>
            TeriaBillPrint = 1288
            ''' <summary>تعداد چاپ برگه صندوق</summary>
            TeriaBillPrintCount = 1289
            ''' <summary>عدم چاپ رمز اينترنت</summary>
            DontPrintPasswordOfInternetTeria = 1290
        End Enum

        ''' <summary>تنظيمات رجيستر کارت</summary>
        Public Enum RegisterSetting
            ''' <summary>ضريب درآمد</summary>
            IncomePersent = 1291
            ''' <summary>ارسال پيامک بعداز ثبت رجيستر</summary>
            SmsSend = 1292
            ''' <summary>ارسال پيامک Exit مهمان</summary>
            TodayExitGuest = 1293
            ''' <summary>ارسال پيامک تسويه اتاق </summary>
            PayOffSendSMS = 1294
            ''' <summary>عدم اجباري بودن کد ملي</summary>
            NotForceNationalCode = 1295
            ''' <summary>اعمال تاريخ پايان قرارداد</summary>
            UseEndDateOfContract = 1296
            ''' <summary>عدم نمايش توضيحات رزرودر چاپ موقت رجيسترکارت</summary>
            DontShowDescriptionOfReserveInTemporaryRegisterPrint = 1297
            ''' <summary>عدم نمايش قرارداد به صورت پيش فرض</summary>
            HideContractDefault = 1298
            ''' <summary>پيام چاپ رجيستر موقت</summary>
            MessageOfTemperoryRegister = 1299
            ''' <summary>پيام لاتين چاپ رجيستر موقت</summary>
            EnglishMessageOfTemperoryRegister = 4455
        End Enum

        ''' <summary>تنظيمات مشترکين</summary>
        Public Enum SubscribSetting
            ''' <summary>مبلغ هر امتياز</summary>
            PrivilegePrice = 1310
            ''' <summary>ارزش هر امتياز جهت تخفيف</summary>
            PrivilegePriceForDiscount = 1312
            ''' <summary>درصد مجاز تخفيف امتياز مشترک</summary>
            DiscountPercentForResident = 1313
            ''' <summary>امکان تغيير کد اشتراک</summary>
            AllowChangeCode = 1314
            ''' <summary>اجباري کردن کد ملي مشترکين</summary>
            ForceNationalCode = 1315
            ''' <summary>برگشت اضافه شارژ مشترکين</summary>
            ReturnDailyUseSubscribe = 1316
            ''' <summary>ايجاد مشترک پس از ثبت رجيستر کارت</summary>
            CreateSubscribeInRegister = 1317
            ''' <summary>اولويت پيش فرض مشترکين شخصي</summary>
            DefaultPriority = 1318
            ''' <summary>ارسال پيامک بعداز ثبت</summary>
            SMSSEND = 2120
            ''' <summary>ارسال پيامک امتياز مشترکين</summary>
            SendSmsSubscribePrivilege = 2121
            ''' <summary>نمايش مبلغ در پبامک امتياز مشترکين</summary>
            ShowPrivilegePriceInSMS = 2122
            ''' <summary>اولويت پيش فرض مشترکين شرکتي</summary>
            DefaultPriorityContractor = 2123
            ''' <summary>اولويت پيش فرض مشترکين آژانسي</summary>
            DefaultPriorityAgency = 2124
            ''' <summary>ايجاد مشترک پس از ثبت شرکت</summary>
            CreateSubscribeInContractor = 2125
            ''' <summary>استفاده از امتياز براي کل هزينه ها</summary>
            UseAllCostForPrivilegeDiscount = 2126
            ''' <summary>امکان استفاده مشترکين از اعتبارهاي هديه در خدمات غير اقامتي</summary>
            UsingScoreInNoneResident = 2127
        End Enum

        ''' <summary>ساير تنظيمات</summary>
        Public Enum OtherSetting
            ''' <summary>هزينه اينترنت</summary>
            InternetPrice = 1320
            ''' <summary>محاسبه ماليات بعداز کسر تخفيف</summary>
            DutyAfterDiscount = 1324
            ''' <summary>ضريب درآمد</summary>
            IncomePersent = 1325
            ''' <summary>ضريب ماليات</summary>
            DutyPersent = 1326
            ''' <summary>آدرس سايت اماکن</summary>
            AmakenWebSite = 1327
            ''' <summary>مبلغ گرد کردن ماليات</summary>
            DutyRoundPrice = 1328
            ''' <summary>نسبت عوارض به ماليات </summary>
            TaxDutyPercent = 1329
            ''' <summary>عدم محاسبه ماليات بن پرسنلي</summary>
            NotDutyForPersonel = 1330
            ''' <summary>چاپ متمرکز صورتحسابها</summary>
            CenteralBillPrint = 1331
            ''' <summary>مديريت فيش هاي بانکي</summary>
            ManagePosBank = 1332
            ''' <summary>تخليه خودکار حافطه</summary>
            RefereshMain = 1333
            ''' <summary>سقف معافيت مالياتي</summary>
            DeductibilityCeiling = 1334
            ''' <summary>آدرس داشبورد مديريتي</summary>
            ManagementDashboardAddress = 1335
            ''' <summary>شناسه ي مهمانان اعتباري</summary>
            GuestContractorID = 1341
            ''' <summary>کد انبار براي انتقال مصرف مستقيم</summary>
            CodeOfStoreForDirectConsumption = 1342
            ''' <summary>آدرس وب سرويس پاسپورت اسکنر</summary>
            PassportScannerWebserviceUrl = 1343
            ''' <summary>شناسه ي فهرست بهاي هزينه</summary>
            CostPriceListId = 1344
            ''' <summary>شناسه ي فهرست بهاي پرسنل</summary>
            PersonelPriceListId = 1345
            ''' <summary>فعال بودن سقف مجاز دسترسي به داده هاي راکد</summary>
            EnableArchiveDayLong = 1346
            ''' <summary>عدم محاسبه ماليات بن هزينه</summary>
            NotDutyForCostBill = 1348
            ''' <summary>کنترل اتاقهاي تخليه شده هنگام واريز به بانک</summary>
            ControlOfCheckoutRoomsDepositToTheBank = 1349
            ''' <summary>کنترل بن هاي باز اتاقي هنگام واريز به بانک</summary>
            ControlOpenBillsDepositToTheBank = 1350
            ''' <summary>امکان تغيير در آيتم هاي صورتحساب</summary>
            EditBillItems = 1351
        End Enum

        ''' <summary>تنظيمات صورتحساب</summary>
        Public Enum GustBillSetting
            ''' <summary>نمايش همراهان در صورتحساب مهمان</summary>
            ShowCompanionInBilling = 1300
            ''' <summary>پيغام زير صورتحساب مهمان - فارسي</summary>
            GustBillFooterMessageFarsi = 1301
            ''' <summary>پيغام زير صورتحساب مهمان - لاتين</summary>
            GustBillFooterMessageLatin = 1302
            ''' <summary>نمايش هزينه اقامت پس از کسر تخفيف</summary>
            ShowRoomCostByDiscount = 1303
            ''' <summary>پيغام جهت کنترل سقف بدهکاري مهمان و شرکتها</summary>
            ShowMessagePriceRoof = 1304
            ''' <summary>کنترل سقف بدهکاري مهمان و شرکتها</summary>
            CreditControlByPriceRoof = 1305
            ''' <summary>نمايش سرجمع در صورتحساب</summary>
            ShowSumCost = 1306
            ''' <summary>تفکيک نفر اضافه در صورتحساب</summary>
            NotSeparateExtraCost = 1307
            ''' <summary>تفکيک صبحانه شارژ در صورتحساب</summary>
            NotSeparateBreakfastCost = 1308
            ''' <summary>فعال بودن چاپ غير رسمي در صورتحساب</summary>
            EnablePrintWithoutHotelInfo = 1309
            ''' <summary>چاپ 2 به عنوان چاپ پيش فرض</summary>
            IsDefualtPrintWithoutHotelInfo = 2350
            ''' <summary>نمايش هزينه اقامت با احتساب ماليات</summary>
            ShowRoomCostByDuty = 2351
            ''' <summary>نمايش اضافه شارژ پيش فرض در صورتحساب </summary>
            ShowVirtualDailyUseInBill = 2352
            ''' <summary>نمايش اتاق در چاپ صورتحساب مهمان</summary>
            ShowRoomNoBillPrint = 2353
            ''' <summary>پيغام امتياز مشترک زير صورتحساب مهمان</summary>
            SubscribePrivelageInGustBillMsg = 2354
            ''' <summary>اجباري کردن بستن ميني بار در تخليه اتاق</summary>
            ForceCloseMinibarInCheckout = 2355
            ''' <summary>(A5) برگه پيش فرض  صورتحساب</summary>
            IsDefualtPrintA5 = 2356
            ''' <summary>استفاده از ارز</summary>
            UseCurrency = 2357
            ''' <summary>نمايش محاسبه غذاهاي فولبرد</summary>
            ShowComputeFullBoard = 2358
            ''' <summary>تفکيک ستون تخفيف در چاپ صورتحساب</summary>
            SeparateDiscountBillPrint = 2359
            ''' <summary>مسير فايل الکترونيکي صورتحساب</summary>
            BillPrintPdfPath = 4550
            ''' <summary>آدرس وب سرور فايل الکترونيکي صورتحساب</summary>
            BillPrintPdfServicePath = 4551
            ''' <summary>ثبت توضيحات در زمان تخليه</summary>
            RegisterDescriptionCheckOut = 4552
        End Enum

        ''' <summary>تنضيمات رزرو</summary>
        Public Enum ReserveSetting
            ''' <summary>فعال کردن تشخيص رزروهاي سفارشي</summary>
            EnableOfficialReservation = 1347
            ''' <summary>پيغام زير رزرو - فارسي</summary>
            ReserveFooterMessageFarsi = 2100
            ''' <summary>پيغام زير رزرو - لاتين</summary>
            ReserveFooterMessageLatin = 2101
            ''' <summary>ارسال پيامک بعداز ثبت رزرو</summary>
            SmsSend = 2102
            ''' <summary>منفي شدن رزرو</summary>
            ReserveOver = 2103
            ''' <summary>غير فعال کردن رزرو اينترنتي</summary>
            DisableInternetReserve = 2104
            ''' <summary>زمان کنسلي روز قبل جهت جريمه يک شب اقامت</summary>
            ReserveCancelTimeForPenalty = 2105
            ''' <summary>درصد جريمه کنسلي رزرو</summary>
            ReserveCancelPenaltyPercent = 2106
            ''' <summary>کنترل سقف بدهکاري شرکتها در رزرو</summary>
            CreditControlContractInReserve = 2107
            ''' <summary>ارسال ايميل بعد از ثبت رزرو</summary>
            EmailSend = 2108
            ''' <summary>اعمال تخفيف اينترنتي</summary>
            InternetDiscount = 2109
            ''' <summary>محاسبه ماليات بعد از کسر کارمزد</summary>
            DutyAfterKarmozd = 2420
            ''' <summary>قوانين تاييديه رزرو</summary>
            ConfirmationReserveRules = 2421
            ''' <summary>قوانين تاييديه رزرو لاتين</summary>
            ConfirmationReserveLatinRules = 2422
            ''' <summary>قطعي کردن رزروهاي اينترنتي</summary>
            DefinitInternetReserve = 2423
            ''' <summary>محاسبه کارمزد پلکاني رزرو</summary>
            CalculateStairWage = 2424
            ''' <summary>عدم نمايش کارمزدآژانس</summary>
            DontShowWageAgency = 2425
            ''' <summary>کسر اتاقهاي تحت تعمير در آناليز</summary>
            DecrementRepairRoomInAnalize = 2426
            ''' <summary>کارمزد بعد از افزودن ماليات</summary>
            KarmozdByDuty = 2427
            ''' <summary>غيرفعال شدن اطلاعات سفر در بالاي برگه رزرو</summary>
            DontActiveInfoTravelInAboveReserveCard = 2428
            ''' <summary>کنترل بلاک روز رزرو اينترنتي در طول مدت اقامت</summary>
            CheckDayBlockingInStayDuration = 2429
            ''' <summary>عدم کنترل مانده رزرو هنگام کم کردن تعداداتاق يا مدت اقامت</summary>
            DontControlRemainReserveInReduceCountOfRoomOrInhabit = 2430
            ''' <summary>عدم ثبت ضمائم بعد از Exit مهمان </summary>
            UnRegisteredAttachmentsAfterGuestExit = 2431
            ''' <summary>تفکيک ماليات در چاپ تاييديه رزرو</summary>
            TaxSegregationInReserveVerify = 2432
            ''' <summary>ارسال پيامک کنسلي موقت </summary>
            SendSmsTemporaryCancel = 2433
            ''' <summary>ارسال پيامک کنسلي قطعي</summary>
            SendSmsDefiniteCancel = 2434
            ''' <summary>منفي شدن رزرو از رجيستر</summary>
            ReserveOverByRegister = 2435
            ''' <summary>مهلت پرداخت رزرو(دقيقه)</summary>
            DeadLineReservePayLink = 2436
        End Enum

        ''' <summary>تنظيمات پيامک</summary>
        Public Enum SmsSetting
            ''' <summary>نام کاربري</summary>
            UserName = 2110
            ''' <summary>رمز عبور</summary>
            Password = 2111
            ''' <summary>شماره خط</summary>
            LineNumber = 2112
            ''' <summary>ارسال پيام اوقات شرعي</summary>
            SendPrayerTime = 2113
            ''' <summary>ارسال پيام تولد مشترکين</summary>
            SendHappyBirthdaySubscrib = 2114
            ''' <summary>ارسال پيام تولد مهمانان مقيم</summary>
            SendHappyBirthdayResidentGuest = 2115
            ''' <summary>ارسال پيام تولد کل مهمانان </summary>
            SendHappyBirthdayAllGuest = 2116
            ''' <summary>ارسال پيامک اينترنت رستوران</summary>
            SendResturantInternet = 2117
            ''' <summary>مبناي تاريخ ورود مهمانان براي پيامک تولد</summary>
            StartChekinDateAllGuest = 2118
            ''' <summary>ارسال پيامک اينترنت اتاق</summary>
            SendRoomInternet = 2119
            ''' <summary>ارائه دهنده سرويس پيامک </summary>
            SmsWebService = 2480
            ''' <summary>ارسال پيام تبريک تولد پرسنل</summary>
            SendHappyBirthdayPersonel = 2481
            ''' <summary>ارسال پيام تبريک ازدواج</summary>
            SendHappyMarriage = 2482
            ''' <summary>پيامک وضعيت اشغالي اتاق مالک</summary>
            SendOwnerInOutRoom = 2483
            ''' <summary>ارسال پيام تبليغاتي کل مهمانان</summary>
            SendAdvertisingMSGAllGuest = 2484
        End Enum

        ''' <summary>تنظيمات کد حساب سند حسابداري</summary>
        Public Enum AccountCodeSetting
            ''' <summary>کد حساب  مانده مسافر</summary>
            GuestRemain = 2130
            ''' <summary>کد حساب پرداخت نقدي</summary>
            Cash = 2131
            ''' <summary>کد حساب رزرو </summary>
            Reserve = 2132
            ''' <summary>کد حساب پرسنلي</summary>
            Personel = 2133
            ''' <summary>کد پيش فرض حساب بانک-فيش بانکي</summary>
            DefualtBankAccountCode = 2200
            ''' <summary>کد حساب عوارض</summary>
            TaxAccount = 2201
            ''' <summary>ديتابيس فعال حسابداري</summary>
            AccountingSysActiveDataBase = 2202
            ''' <summary>سرور و نام کاربري ديتابيس حسابداري</summary>
            AccountingSysDataBaseIp = 2203
            ''' <summary>کد پيش فرض حساب بانک-دستگاه POS</summary>
            DefualtBankAccountCodePos = 2204
            ''' <summary>کد پيش فرض حساب بانک-نقدي</summary>
            DefualtBankAccountCodeCash = 2205
            ''' <summary> کل و معين حسابهاي دريافتني</summary>
            ReceivedAccountCode = 2206
            ''' <summary>نمايش کاربر و زمان ايجاد و ويرايش سندهاي حسابداري</summary>
            ShowUserAndDate = 2207
            ''' <summary>Delete سطراول فايل اکسل سند</summary>
            RemoveFirstLineExcel = 2208
            ''' <summary>استفاده از نسخه جديد نرم افزار حسابداري</summary>
            UsingNewVersionAccountingSoftware = 2209
            ''' <summary>پيشنهاد کد کل کدينگ حسابداري</summary>
            SuggestionAccountLevels1 = 2920
            ''' <summary>کد واسط براي صدور سند</summary>
            AccInterfaces = 2921
            ''' <summary>کدينگهاي واسط براي چک - حداقل سه سطحي</summary>
            ChequeMinLevel = 3091
            ''' <summary>شرح رديف بدهکار براي سيستم خزانه داري</summary>
            DebitChequesDescription = 3092
            ''' <summary>شرح رديف بستانکار براي سيستم خزانه داري</summary>
            CreditChequesDescription = 3093
            ''' <summary>نمايش تمامي وضعيت اسناد</summary>
            ShowAllVoucherStatus = 3094
            ''' <summary>شناسايي جدول تفضيلي - پرسنلي </summary>
            AccountTablePersonnel = 3096
            ''' <summary>مرتب سازي سند به صورت صعودي</summary>
            SortVouchers = 3097
            ''' <summary>نمايش تمام سالهاي مالي</summary>
            ShowAllFinance = 3098
            ''' <summary>تفکيک اطلاعات فيزيکي و ريالي اسناد انبار</summary>
            SeparationOfPhysicalAndRialInformationOfDocuments = 3099
        End Enum

        ''' <summary>تنظيمات لاندري</summary>
        Public Enum LandrySetting
            ''' <summary>درصد اضافه فاکتورهاي فوري</summary>
            FastBillPersent = 2140
            ''' <summary>نوع برگه صندوق (A6=1)</summary>
            CashPageType = 2141
            ''' <summary>عدم محاسبه ماليات لاندري</summary>
            NotDuty = 2142
        End Enum

        ''' <summary>تنظيمات ايميل</summary>
        Public Enum EmailSetting
            ''' <summary>SMTP</summary>
            SMTP = 2235
            ''' <summary>Port</summary>
            Port = 2236
            ''' <summary>UserName</summary>
            UserName = 2237
            ''' <summary>Password</summary>
            Password = 2238
            ''' <summary>ارسال ايميل بعد از تسويه رجيستر</summary>
            EmailSendAfterPayOff = 2239
            ''' <summary>مسير فايل تصويري ايميل</summary>
            EmailPicAttachmentPath = 2240
            ''' <summary>ارسال ايميل تولد مهمانان مقيم</summary>
            EmailSendBirthdayResidentGuest = 2321
            ''' <summary>مسير فايل تصويري ايميل تولد</summary>
            EmailPicBirthdayAttachmentPath = 2322
            ''' <summary>ارسال ايميل تاييديه رزرو</summary>
            EmailSendAfterConfirmReserve = 2323
            ''' <summary>مسير فايل تصويري ايميل تاييديه رزرو</summary>
            EmailPicConfirmReserveAttachmentPath = 2324
            ''' <summary>ارسال ايميل تولد کل مهمانان</summary>
            EmailSendBirthdayAllGuest = 2325
            ''' <summary>سرور نظر سنجي</summary>
            ServerPoll = 2326
            ''' <summary>پورت سرور نظر سنجي</summary>
            PortPoll = 2327
        End Enum

        ''' <summary>تنظيمات فروشگاه</summary>
        Public Enum ShopSetting
            ''' <summary>نوع برگه صندوق (A6=1)</summary>
            CashPageType = 2260
            ''' <summary>عدم محاسبه ماليات فروشگاه</summary>
            NotDuty = 2261
            ''' <summary>اجباري کردن کد ميزبان</summary>
            ForceHost = 2262
        End Enum

        ''' <summary>تنظيمات خانه داري</summary>
        Public Enum RoomKeepingSetting
            ''' <summary>عدم محاسبه ماليات ميني بار</summary>
            NotDuty = 2280
            ''' <summary>وضعيت نظافت شده</summary>
            CleaningStatus = 2281
            ''' <summary>درصد حق سرويس</summary>
            ServicePercent = 2282
            ''' <summary>چاپ برگه ملزومات پس از ثبت صورتحساب</summary>
            SuppliesPrint = 2283
            ''' <summary>استفاده از اعلام چک اوت</summary>
            UseAnnounceCheckOut = 2284
            ''' <summary>حداکثر زمان (ساعت) DND</summary>
            MaximumDNDTime = 2285
            ''' <summary>قطعي کردن بن خسارت از طريق تبلت</summary>
            DetermineTheDamageBillByTablet = 2286
        End Enum

        ''' <summary>تنظيمات رزرو خدمات</summary>
        Public Enum ServiceReserveSetting
            ''' <summary>ارسال پيامک بعداز ثبت رزرو</summary>
            SmsSend = 2360
            ''' <summary>ارسال ايميل بعداز ثبت رزرو</summary>
            EmailSend = 2361
        End Enum

        ''' <summary>اعلام چک اوت</summary>
        Public Enum AnnounceCheckOut
            ''' <summary>ثبت اعلام چک اوت</summary>
            InsertAnnounceCheckOut = 4486
            ''' <summary>پايان اعلام چک اوت</summary>
            EndAnnounceCheckOut = 4487
            ''' <summary>لغو اعلام چک اوت</summary>
            CancelAnnounceCheckOut = 4488
        End Enum

        ''' <summary>انواع مشخصه هاي اتاق</summary>
        Public Enum RoomPropertyType
            ''' <summary>وضعيت</summary>
            Status = 1481
            ''' <summary>امکانات اتاق</summary>
            Facilities = 1482
            ''' <summary>تعداد اتاق بلاک شده</summary>
            ReserveRoomBlocked = 1483
            ''' <summary>تعداد اتاق بلاک شده روز</summary>
            ReserveRoomDailyBlocked = 1484
            ''' <summary>تعداد اتاق بلاک شده اينترنتي</summary>
            ReserveRoomInternetBlocked = 1485
            ''' <summary>اطلاعات خانه داري</summary>
            RoomInfo = 1486
            ''' <summary>پيغام اتاق</summary>
            RoomMessage = 1487
            ''' <summary>مالک</summary>
            Owner = 1488
            ''' <summary>قابل واگذاري</summary>
            Available = 1489
            ''' <summary>اولويت سرويس</summary>
            ServicePriorty = 1490
            ''' <summary>اعلام چک اوت</summary>
            AnnounceCheckOut = 4465
            ''' <summary>بلاک اينترنتي ساير فروشندگان</summary>
            ReserveRoomOtherInternetBlocked = 4466
        End Enum

        ''' <summary>مراکز هزينه مشخص</summary>
        Public Enum CostCenterItems
            ''' <summary>هزينه اقامت</summary>
            ResidentCost = 1491
            ''' <summary>صبحانه</summary>
            Breakfast = 1492
            ''' <summary>ناهار</summary>
            Lunch = 1493
            ''' <summary>شام</summary>
            Dinner = 1494
            ''' <summary>کافي شاپ</summary>
            Teria = 1495
            ''' <summary>ميني بار</summary>
            Minibar = 1496
            ''' <summary>تلفن</summary>
            Telephone = 1497
            ''' <summary>پارکينگ</summary>
            Parking = 1498
            ''' <summary>کنسلي رزرو</summary>
            ReserveCancel = 1499
            ''' <summary>کارمزد رزرو</summary>
            ReserveJourneyWork = 1500
            ''' <summary>عوارض</summary>
            Duty = 1501
            ''' <summary>تخفيف</summary>
            Discount = 1502
            ''' <summary>پيش دريافت</summary>
            PrePay = 1503
            ''' <summary>تسويه حساب اتاق</summary>
            RoomPayoff = 1504
            ''' <summary>علي الحساب</summary>
            TemporaryCash = 1505
            ''' <summary>پرداخت رزرو</summary>
            ReservePayment = 1506
            ''' <summary>پرداخت قرارداد</summary>
            ContractPayment = 1507
            ''' <summary>انتقال صندوق</summary>
            CashTransfer = 1508
            ''' <summary>بانک</summary>
            Bank = 1509
            ''' <summary>تعهد قرارداد</summary>
            ContractGuarantee = 1510
            ''' <summary>هزينه سرويس</summary>
            Service = 1511
            ''' <summary>هزينه VIP</summary>
            VIP = 1512
            ''' <summary>کارت هديه</summary>
            PresentCard = 1513
            ''' <summary>لاندري</summary>
            Landry = 1514
            ''' <summary>فروشگاه</summary>
            Shop = 1515
            ''' <summary>رزرو خدمات</summary>
            ServiceReserve = 1516
            ''' <summary>ترانسفر</summary>
            Transfer = 1517
            ''' <summary>ملزومات اتاق</summary>
            RoomSupplies = 1518
            ''' <summary>ورودي رزرو خدمات</summary>
            ServiceReserveInning = 1519
            ''' <summary>اسپا</summary>
            SpaCenter = 1520
            ''' <summary>پرداخت به معرف (راهنما (</summary>
            PayToLeader = 1521
            ''' <summary>امتياز مشترک</summary>
            UsedScore = 1532
            ''' <summary>خسارت</summary>
            Damage = 1533
        End Enum

        ''' <summary>انواع مشخصه هاي سرويسها</summary>
        Public Enum ServicePropertyType
            ''' <summary>آيتم هاي ميني بار</summary>
            MinibarItem = 1522
            ''' <summary>خدمات عمومي</summary>
            Service = 1523
            ''' <summary>رستوران سرويس دهنده</summary>
            FoodRestaurant = 1524
            ''' <summary>کد تلفني ميني بار</summary>
            TelMinibarCode = 1525
            ''' <summary>مواد اوليه غذا</summary>
            ServiceItem = 1526
            ''' <summary>گروه غذايي رستوران</summary>
            ResturantFoodGroups = 1527
            ''' <summary>گروه غذايي تريا</summary>
            TeriaFoodGroups = 1528
            ''' <summary>ارتباط سرويس ها با محل</summary>
            ServiceAndLocationRelated = 1529
            ''' <summary>خواص غذا</summary>
            FoodFeatures = 1530
            ''' <summary>گروه دستورالعمل غذا</summary>
            Recipe = 2550
            ''' <summary>آيتم هاي ملزومات</summary>
            RoomSupplieItems = 2551
            ''' <summary>غذاهاي ترکيبي</summary>
            CombinatoryFood = 2552
            ''' <summary>آيتم هاي ليست منوي غذايي</summary>
            FoodListMenuItems = 2553
            ''' <summary>نياز به تجهيز</summary>
            DeviceRequire = 2554
        End Enum

        ''' <summary>123</summary>
        Public Enum Empty1
            ''' <summary>123</summary>
            Empty_1 = 1531
        End Enum

        ''' <summary>انواع مراکز هزينه</summary>
        Public Enum CostCenterType
            ''' <summary>درآمد</summary>
            Income = 1551
            ''' <summary>مانده مسافر</summary>
            GuestRemain = 1552
            ''' <summary>رزرو</summary>
            Reserve = 1553
            ''' <summary>قرارداد</summary>
            Contract = 1554
            ''' <summary>پرسنل</summary>
            Personel = 1555
            ''' <summary>صندوق</summary>
            Cash = 1556
            ''' <summary>بانک</summary>
            Bank = 1557
            ''' <summary>هزينه</summary>
            Cost = 1558
            ''' <summary>دستگاه Pos</summary>
            Pos = 1559
        End Enum

        ''' <summary>مرجع ثبت رکورد</summary>
        Public Enum RowReferenceType
            ''' <summary></summary>
            None = 1561
            ''' <summary>صورتحساب</summary>
            Bill = 1562
            ''' <summary>تلفن</summary>
            Telephone = 1563
            ''' <summary>پارکينگ</summary>
            Parking = 1564
            ''' <summary>شارژ</summary>
            Charge = 1565
            ''' <summary>شارژشب قبل</summary>
            LastNightCharge = 1566
            ''' <summary>اضافه شارژ</summary>
            DailyUse = 1567
            ''' <summary>IPTV</summary>
            IPTV = 1568
            ''' <summary>ريجسترکارت</summary>
            RegisterCard = 1569
            ''' <summary>تخفيف مشترک</summary>
            SubscribDiscount = 1570
            ''' <summary>رکوردهاي سيستمي</summary>
            System = 1571
            ''' <summary>کنسلي رزرو</summary>
            ReserveCancel = 1572
            ''' <summary>شارژ Exit زود هنگام</summary>
            RoomChargeExitEarly = 1573
            ''' <summary>شارژ تاخير در ورود</summary>
            RoomChargeCheckinDelay = 1574
        End Enum

        ''' <summary>نوع ارائه هزينه</summary>
        Public Enum CostOfferType
            ''' <summary>فروش</summary>
            Offer = 1581
            ''' <summary>برگشت</summary>
            TurnBack = 1582
        End Enum

        ''' <summary>نوع رديف جزء هزينه ها</summary>
        Public Enum CashItemRowType
            ''' <summary>اصلي</summary>
            Main = 1591
            ''' <summary>نفر اضافه</summary>
            Extra = 1592
            ''' <summary>رديف فرزند</summary>
            Child = 1593
            ''' <summary>طرف مقابل</summary>
            Beside = 1594
        End Enum

        ''' <summary>انواع رديفهاي قيمت رجيسترکارت</summary>
        Public Enum RegisterCostTypes
            ''' <summary>شارژ</summary>
            Charge = 1601
            ''' <summary>ساير</summary>
            Other = 1602
        End Enum

        ''' <summary>ماهيت حسابها</summary>
        Public Enum AccountNature
            ''' <summary>بدهکار</summary>
            Debit = 1611
            ''' <summary>بستانکار</summary>
            Credit = 1612
            ''' <summary>بدهکار/يستانکار</summary>
            DebitCredit = 1613
        End Enum

        ''' <summary>روش هاي تشخيص حساب مقابل و کد مالي عوامل هزينه</summary>
        Public Enum CostCenterRecognition
            ''' <summary>نحوه پرداخت</summary>
            PayType = 1621
            ''' <summary>رستوران</summary>
            Restaurant = 1622
            ''' <summary>عامل هزينه پايه</summary>
            CostCenter = 1623
            ''' <summary>نوع ارائه هزينه</summary>
            CostOfferType = 1624
            ''' <summary>کافي شاپ</summary>
            Teria = 1625
            ''' <summary>فروشگاه</summary>
            Shop = 1626
        End Enum

        ''' <summary>انواع مشخصه هاي مراکز هزينه</summary>
        Public Enum CostCenterPropertyType
            ''' <summary>کد مالي</summary>
            Account = 1631
            ''' <summary>طرف مقابل</summary>
            AgainstSide = 1632
            ''' <summary>وابستگي به محلهاي برگزاري</summary>
            LocationDependence = 1633
            ''' <summary>کد مالي طرف مقابل</summary>
            BesideAccID = 1634
        End Enum

        ''' <summary>وضعيت درآمد</summary>
        Public Enum IncomeStatus
            ''' <summary>باز</summary>
            Open = 1641
            ''' <summary>ثبت شده</summary>
            Register = 1642
            ''' <summary>قطعي</summary>
            Definite = 1643
        End Enum

        ''' <summary>وضعيت سند</summary>
        Public Enum VoucherStatus
            ''' <summary>ابطال موقت</summary>
            Cancel = 1650
            ''' <summary>پيش نويس</summary>
            Temporary = 1651
            ''' <summary>ثبت شده</summary>
            Register = 1652
            ''' <summary>قطعي</summary>
            Definite = 1653
            ''' <summary>تاييد شده</summary>
            Verify = 1654
        End Enum

        ''' <summary>انواع سند</summary>
        Public Enum VoucherTypes
            ''' <summary>عمومي</summary>
            General = 1661
            ''' <summary>درآمد</summary>
            Income = 1662
            ''' <summary>حسابداري انبار</summary>
            Store = 1663
            ''' <summary>افتتاحيه</summary>
            Opening = 1664
            ''' <summary>اختتاميه</summary>
            Closing = 1665
            ''' <summary>سند حقوق</summary>
            Salary = 1666
            ''' <summary>حسابداري خريد</summary>
            Purchase = 1667
            ''' <summary>خزانه داري-دريافت</summary>
            ChequesReceive = 1668
            ''' <summary>خزانه داري-پرداخت</summary>
            ChequesIssue = 1669
            ''' <summary>تنخواه</summary>
            fund = 3050
            ''' <summary>بستن حساب موقت</summary>
            CloseTemporaryAccount = 3176
            ''' <summary>حسابداري اموال</summary>
            Possession = 3177
        End Enum

        ''' <summary>وضعيت صندوق</summary>
        Public Enum CashStatus
            ''' <summary>Delete شده</summary>
            Deleted = 1670
            ''' <summary>فعال</summary>
            Active = 1671
            ''' <summary>برگشت داده شده</summary>
            TurnBack = 1672
            ''' <summary>رديف برگشتي</summary>
            TurnBackCancel = 1673
            ''' <summary>موقت</summary>
            Temp = 1674
        End Enum

        ''' <summary>روشهاي تسويه حساب رجيسترکارت</summary>
        Public Enum RegisterPayoffType
            ''' <summary>نقدي</summary>
            Cash = 1681
            ''' <summary>انتقال به حساب</summary>
            TransferRoom = 1682
            ''' <summary>تعهد</summary>
            Guarantee = 1683
        End Enum

        ''' <summary>انواع مشخصه هاي جدول صندوق</summary>
        Public Enum CashPropertyType
            ''' <summary>شماره حساب</summary>
            BankAccount = 1691
            ''' <summary>ارز پرداختي</summary>
            CurrencyType = 1692
            ''' <summary>تاريخ پرداخت</summary>
            PayDate = 1693
        End Enum

        ''' <summary>وضعيت رزرو</summary>
        Public Enum ReserveStatus
            ''' <summary>کنسلي موقت</summary>
            TempCancel = 1698
            ''' <summary>کنسلي پرداخت شده</summary>
            PayCancel = 1699
            ''' <summary>کنسلي قطعي شده</summary>
            Cancel = 1700
            ''' <summary>موقت</summary>
            Temporary = 1701
            ''' <summary>قطعي</summary>
            Definite = 1702
            ''' <summary>رجيستر شده</summary>
            Register = 1703
            ''' <summary>Delete شده</summary>
            Delete = 1709
        End Enum

        ''' <summary>انواع صورتحسابها</summary>
        Public Enum BillType
            ''' <summary>رستوران</summary>
            Restaurant = 1711
            ''' <summary>کافي شاپ</summary>
            Teria = 1712
            ''' <summary>ميني بار</summary>
            Minibar = 1713
            ''' <summary>کارت هديه</summary>
            PresentCard = 1714
            ''' <summary>لاندري</summary>
            Landry = 1715
            ''' <summary>فروشگاه</summary>
            Shop = 1716
            ''' <summary>ملزومات اتاق</summary>
            RoomSupplies = 1717
            ''' <summary>خسارت</summary>
            Damage = 1718
        End Enum

        ''' <summary>انواع فهرست بها</summary>
        Public Enum PriceListType
            ''' <summary>EconomyClass</summary>
            [Global] = 1721
            ''' <summary>FirstClass</summary>
            FirstClass = 1722
            ''' <summary>BussinesClass</summary>
            BussinesClass = 1723
            ''' <summary>قيمت اتحاديه</summary>
            EtehadiePrice = 1728
            ''' <summary>شرکتي</summary>
            Contract = 1729
        End Enum

        ''' <summary>انواع قيمتهاي فهرست بها</summary>
        Public Enum PriceListCostType
            ''' <summary>انواع اتاقها</summary>
            RoomType = 1731
            ''' <summary>غذاها-خدمات</summary>
            Service = 1732
            ''' <summary>نفر اضافه</summary>
            ExtraGuest = 1733
            ''' <summary>درصد ماليات بر ارزش افزوده</summary>
            DutyPercent = 1734
            ''' <summary>تعرفه ورودي پارکينگ</summary>
            ParkingEnterTariff = 1735
            ''' <summary>تعرفه ساعتي پارکينگ</summary>
            ParkingHourTariff = 1736
            ''' <summary>تعرفه مهمانان پارکينگ</summary>
            ParkingGuestTariff = 1737
            ''' <summary>درصد ماليات بر ارزش افزوده آينده</summary>
            NextDutyPercent = 1738
            ''' <summary>سالن ها</summary>
            Salon = 1739
            ''' <summary>کالا</summary>
            Good = 1740
            ''' <summary>تخفيفات</summary>
            Discounts = 2860
            ''' <summary>تعرفه ورودي آزاد اسپا</summary>
            SpaEnterTariff = 2861
            ''' <summary>تعرفه زماني (دقيقه)آزاد اسپا</summary>
            SpaTimeTariff = 2862
            ''' <summary>تعرفه ميهمانان ورودي اسپا</summary>
            SpaGuestEnterTariff = 2863
            ''' <summary>تعرفه زماني ميهمانان (دقيقه)اسپا</summary>
            SpaTimeGuestTariff = 2864
        End Enum

        ''' <summary>انواع عملگرها</summary>
        Public Enum Operators
            ''' <summary>=</summary>
            Equal = 1741
            ''' <summary><></summary>
            NotEqual = 1742
            ''' <summary>></summary>
            Great = 1743
            ''' <summary><</summary>
            Less = 1744
            ''' <summary>>=</summary>
            GreatEqual = 1745
            ''' <summary><=</summary>
            LessEqual = 1746
            ''' <summary> IN</summary>
            [In] = 1747
            ''' <summary> NOT IN</summary>
            NotIn = 1748
            ''' <summary>LIKE</summary>
            [Like] = 1749
            ''' <summary>BETWEEN</summary>
            Between = 1750
            ''' <summary>IS NULL</summary>
            IsNull = 1751
            ''' <summary>IS NOT NULL</summary>
            IsNotNull = 1752
        End Enum

        ''' <summary>مشخصه هاي کاربر</summary>
        Public Enum UserProperties
            ''' <summary>بروزرساني خودکار رک</summary>
            RackRefreshEnabled = 1761
            ''' <summary>نمايش آيکون رک</summary>
            RoomIconDisplay = 1762
            ''' <summary>نمايش رنگ رک</summary>
            RoomColorDisplay = 1763
            ''' <summary>نمايش آيکون Exitي ها</summary>
            CheckoutStatusIcomDisplay = 1764
            ''' <summary>نمايش ToolTip</summary>
            ToolTipDisplay = 1765
            ''' <summary>نمايش آيکون شرکن</summary>
            ContractorIconDisplay = 1766
            ''' <summary>نمايش آيکون پيغام</summary>
            MessageIcomDisplay = 1767
            ''' <summary>نمايش آيکون يادداشت</summary>
            NotificationIconDisplay = 1768
            ''' <summary>عنوان</summary>
            RoomTitleTransparency = 1769
            ''' <summary>زمان بروزرساني رک</summary>
            RackRefreshTime = 1770
            ''' <summary>نمايش آيکون مشترکين</summary>
            CustomerIconDisplay = 1771
            ''' <summary>نمايش آيکون مهمان عادي</summary>
            NotCustomerIconDisplay = 1772
            ''' <summary>نمايش اختصار اتاق</summary>
            ShowShortRoomName = 1773
            ''' <summary>نمايش آيکن روزتولد</summary>
            ShowBirthdayIcon = 1774
            ''' <summary>نمايش آيکن سالگردازدواج</summary>
            ShowMarriageDayIcon = 1775
            ''' <summary>سقف مجاز دسترسي به داده هاي راکد - تعداد روز</summary>
            ArchiveDayLong = 1776
            ''' <summary>جداسازي بلاک ها</summary>
            BlockSeparate = 1777
        End Enum

        ''' <summary>نوع ترانسفر</summary>
        Public Enum TransferType
            ''' <summary>ورودي</summary>
            Input = 1801
            ''' <summary>Exitي</summary>
            Output = 1802
            ''' <summary>گشت</summary>
            Tour = 1803
        End Enum

        ''' <summary>وضعيت ترانسفر</summary>
        Public Enum TransferStatus
            ''' <summary>درخواست</summary>
            Requested = 1811
            ''' <summary>انجام شده</summary>
            Transfered = 1812
            ''' <summary>ابطال</summary>
            Canceled = 1813
        End Enum

        ''' <summary>انواع مجوزها</summary>
        Public Enum PermissionType
            ''' <summary>گروه</summary>
            Group = 1821
            ''' <summary>مجوز</summary>
            Permission = 1822
            ''' <summary>نقش</summary>
            Role = 1823
        End Enum

        ''' <summary>انواع مشخصه مجوزها</summary>
        Public Enum PermissionPropertyType
            ''' <summary>آيتمهاي نقش</summary>
            RoleItem = 1831
        End Enum

        ''' <summary>انواع اشياء سيستم</summary>
        Public Enum SystemObjectType
            ''' <summary>منو</summary>
            Menu = 1841
            ''' <summary>زيرمنو</summary>
            SubMenu = 1842
            ''' <summary>آيتم منو</summary>
            MenuItem = 1843
            ''' <summary>سيستم</summary>
            System = 1844
            ''' <summary>فرم</summary>
            Form = 1845
            ''' <summary>کنترل</summary>
            Control = 1846
            ''' <summary>گروه</summary>
            Group = 1847
        End Enum

        ''' <summary>انواع آيکون</summary>
        Public Enum ImageType
            ''' <summary>منو</summary>
            Menu = 1851
            ''' <summary>رک</summary>
            Rack = 1852
            ''' <summary>آرم شرکتها</summary>
            ContractorArm = 1853
        End Enum

        ''' <summary>منبع اطلاعاتي تلفن</summary>
        Public Enum TelephoneSorceBase
            ''' <summary>فايل متني</summary>
            TextFile = 1861
            ''' <summary>پايگاه اطلاعاتي Access</summary>
            Access = 1862
            ''' <summary>پايگاه اطلاعاتي Sql</summary>
            SqlServer = 1863
        End Enum

        ''' <summary>نوع تاريخ</summary>
        Public Enum DateType
            ''' <summary>شمسي</summary>
            Solar = 1871
            ''' <summary>ميلادي</summary>
            Gregorian = 1872
            ''' <summary>قمري</summary>
            Lunar = 1873
        End Enum

        ''' <summary>نوع ستون فايل متني</summary>
        Public Enum TextFileColumnType
            ''' <summary>طول ثابت</summary>
            FixedLength = 1881
            ''' <summary>کارکتر جدا کننده</summary>
            SeparatorCharacter = 1882
        End Enum

        ''' <summary>نوع کنترل تلفن</summary>
        Public Enum TelephoneControlType
            ''' <summary>پايگاه اطلاعاتي Sql</summary>
            SqlServer = 1891
            ''' <summary>فايل</summary>
            File = 1892
        End Enum

        ''' <summary>انواع فرمت تاريخ</summary>
        Public Enum DateFormat
            ''' <summary>mm/dd/yyyy</summary>
            mmddyyyy = 1901
            ''' <summary>dd/mm/yy</summary>
            ddmmyy = 1902
            ''' <summary>yy/mm/dd</summary>
            yymmdd = 1903
            ''' <summary>yyyy/mm/dd</summary>
            yyyymmdd = 1904
        End Enum

        ''' <summary>انواع فرمت ساعت</summary>
        Public Enum TimeFormat
            ''' <summary>h:m:s</summary>
            hms = 1911
            ''' <summary>hh:mm:ss</summary>
            hhmmss = 1912
            ''' <summary>h:m:s AM/MP</summary>
            hmsAM_PM = 1913
            ''' <summary>hh:mm:ss AM/MP</summary>
            hhmmssAM_PM = 1914
            ''' <summary>H:m:s</summary>
            Hms24 = 1915
            ''' <summary>HH:mm:ss</summary>
            HHmmss24 = 1916
        End Enum

        ''' <summary>انواع فرمت مدت مکالمه</summary>
        Public Enum DurationFormat
            ''' <summary>h:m:s</summary>
            hms = 1921
            ''' <summary>mm:ss</summary>
            mmss = 1922
            ''' <summary>دقيقه</summary>
            Minute = 1923
            ''' <summary>ثانيه</summary>
            Sec = 1924
        End Enum

        ''' <summary>انواع تلفنها</summary>
        Public Enum TelephoneBookItemType
            ''' <summary>منزل</summary>
            HomeNumber = 1931
            ''' <summary>محل کار</summary>
            WorkNumber = 1932
            ''' <summary>موبايل</summary>
            MibileNumber = 1933
            ''' <summary>فکس</summary>
            FaxNumber = 1934
        End Enum

        ''' <summary>انواع ضمائم</summary>
        Public Enum AttachmentType
            ''' <summary>تصوير پرسنل</summary>
            PeopleImage = 1941
            ''' <summary>کپي شناسنامه</summary>
            Certificate = 1942
            ''' <summary>کپي کارت ملي</summary>
            NationalCard = 1943
            ''' <summary>متن نامه - قالب بندي</summary>
            LetterTextFormatted = 1944
            ''' <summary>متن نامه</summary>
            LetterText = 1945
            ''' <summary>ضمائم نامه</summary>
            LetterAttachment = 1946
        End Enum

        ''' <summary>انواع شيفت</summary>
        Public Enum ShiftType
            ''' <summary>صندوق</summary>
            Cash = 1951
            ''' <summary>رستوران</summary>
            Restaurant = 1952
            ''' <summary>کافي شاپ</summary>
            Teria = 1953
            ''' <summary>ساير</summary>
            Other = 1959
        End Enum

        ''' <summary>وضعيت مشترکين</summary>
        Public Enum SubscribeStatus
            ''' <summary>فعال</summary>
            Active = 1961
            ''' <summary>غير فعال</summary>
            DeActive = 1962
        End Enum

        ''' <summary>انواع PocketPc</summary>
        Public Enum PocketPcType
            ''' <summary>رستوران-ناهار</summary>
            Restaurant = 1991
            ''' <summary>کافي شاپ</summary>
            Teria = 1992
            ''' <summary>خانه داري</summary>
            RoomKeeping = 1993
            ''' <summary>رستوران-شام</summary>
            Restaurant_D = 1994
            ''' <summary>رستوران-صبحانه</summary>
            Restaurant_B = 1995
        End Enum

        ''' <summary>انواع مشخصه هاي صورتحساب</summary>
        Public Enum BillPropertyType
            ''' <summary>تاريخ ارسال چاپ به صندوق</summary>
            CashPrintDate = 2001
            ''' <summary> تاريخ ارسال چاپ به آشپزخانه</summary>
            KitchenPrintDate = 2002
            ''' <summary>تاريخ اعتبار</summary>
            CreditDate = 2003
            ''' <summary>نوع لاندري</summary>
            LandryType = 2004
            ''' <summary>نوع تحويل</summary>
            DeliveryType = 2005
            ''' <summary>تاريخ تقريبي تحويل</summary>
            ApproximateDeliveryDate = 2006
            ''' <summary>ارسال جهت رويت آشپزخانه</summary>
            ForViewKitchenPrint = 2007
            ''' <summary>تاييدرويت آشپزخانه</summary>
            VerfiyKitchenPrint = 2008
            ''' <summary>تحويل غذا به مهمان</summary>
            DeliveryToGuest = 2009
        End Enum

        ''' <summary>وضعيت رزروهاي اينترنتي</summary>
        Public Enum InternetReserveStatus
            ''' <summary>ابطال</summary>
            Cancel = 2010
            ''' <summary>موقت</summary>
            Temporary = 2011
            ''' <summary>قطعي</summary>
            Definite = 2012
        End Enum

        ''' <summary>نوع واحد پرينتر</summary>
        Public Enum PrintUnitType
            ''' <summary>صندوق</summary>
            Cash = 2021
            ''' <summary>واحد دسر</summary>
            DessertUnit = 2022
            ''' <summary>سرويس اتاق</summary>
            RoomService = 2023
            ''' <summary>برگه حسابداري </summary>
            FinancialPrint = 2024
            ''' <summary>خانه داري</summary>
            RoomKeeping = 2025
        End Enum

        ''' <summary>نوع تخفيف</summary>
        Public Enum DiscountType
            ''' <summary>تخفيف مشترک</summary>
            Subscrib = 2030
            ''' <summary>تخفيف اينترنتي</summary>
            Internet = 2031
        End Enum

        ''' <summary>نوع مقدار دامنه</summary>
        Public Enum DomainValueType
            ''' <summary>توضيحات vip</summary>
            VipDescription = 2040
            ''' <summary>مبلغ Vip</summary>
            VipPrice = 2041
            ''' <summary>آشپزخانه پيش فرض رستوران</summary>
            DefultResturantKitchen = 2042
            ''' <summary>فهرست بهاي پيش فرض رستوران</summary>
            DefultResturantPriceList = 2043
            ''' <summary>تخفيف پيش فرض رستوران</summary>
            DefultResturantDiscount = 2044
            ''' <summary>حق سرويس پيش فرض رستوران</summary>
            DefultResturantService = 2045
            ''' <summary>مشمول ماليات رستوران</summary>
            DefultResturantHasDuty = 2046
            ''' <summary>تبديل واحد</summary>
            UnitConvert = 2047
            ''' <summary>ارزش ريالي ارز</summary>
            CurrencyTypeCost = 2048
            ''' <summary>نحوه پرداخت پيش فرض رستوران</summary>
            DefultResturantPayType = 2049
            ''' <summary>مشمول ماليات اسپا</summary>
            DefultSpatHasDuty = 2050
            ''' <summary>تخفيف پيش فرض اسپا</summary>
            DefultSpaDiscount = 2051
            ''' <summary>محاسبه تعرفه ورودي ميهمان به صورت روزانه</summary>
            CalculateSpaGuestEntryDaily = 2052
            ''' <summary>محدوديت رزرو اينترنتي</summary>
            InternetReserveRestriction = 2053
        End Enum

        ''' <summary>نوع آژانس رزرواسيون</summary>
        Public Enum AgencyType
            ''' <summary>اعتباري</summary>
            Credit = 2060
            ''' <summary>نقدي</summary>
            Cash = 2061
        End Enum

        ''' <summary>وضعيت ارسال پيامک</summary>
        Public Enum SMSSendStatus
            ''' <summary>ارسال شده</summary>
            Sended = 2066
            ''' <summary>خطا در ارسال</summary>
            ErrSending = 2067
            ''' <summary>فعال</summary>
            Active = 2068
            ''' <summary>غير فعال</summary>
            NoActive = 2069
        End Enum

        ''' <summary>نوع پيامک</summary>
        Public Enum SmsRowType
            ''' <summary>رجيستر</summary>
            Register = 2072
            ''' <summary>رزرو</summary>
            Reserve = 2073
            ''' <summary>پشتيبان</summary>
            Supporter = 2074
            ''' <summary>اشتراک</summary>
            Subscribe = 2075
            ''' <summary>کنسلي رزرو قطعي</summary>
            ReserveCancel = 2076
            ''' <summary>ساير متنهاي تعريف شده</summary>
            Others = 2077
            ''' <summary>کنسلي رزرو موقت</summary>
            TempReserveCancel = 2078
            ''' <summary>تسويه حساب رجيستر</summary>
            RegisterPayOff = 2079
            ''' <summary>پيام تبريک تولد</summary>
            HappyBirthdayMessage = 2250
            ''' <summary>اوقات شرعي</summary>
            PrayerTime = 2251
            ''' <summary>متن پيام امتياز مشترکين </summary>
            SubscribePrivilege = 2252
            ''' <summary>متن پيامک اينترنت</summary>
            ResturantInternet = 2253
            ''' <summary>متن پيامک Exit مهمان</summary>
            TodayExitGuest = 2254
            ''' <summary>رزرو خدمات</summary>
            SmsSend = 2255
            ''' <summary>پيام تبريک تولد پرسنل</summary>
            HappyBirthdayPersonelMessage = 2256
            ''' <summary>پيام تبريک ازدواج</summary>
            HappyMarriageMessage = 2257
            ''' <summary>متن پيامک رزرو خدمات</summary>
            ServiceReserve = 2258
            ''' <summary>پيامک اشغال اتاق مالک</summary>
            RoomOwnerCheckin = 2259
            ''' <summary>پيامک تخليه اتاق مالک</summary>
            RoomOwnerCheckout = 4240
            ''' <summary>تاکسي سرويس</summary>
            TaxiService = 4510
            ''' <summary>پيامک تبليغاتي</summary>
            SMSAdvertising = 4511
            ''' <summary>رزرو اينترنتي</summary>
            InternetReserve = 4512
            ''' <summary>لينک پرداخت رزرو</summary>
            ReservePayLink = 4513
            ''' <summary>اطلاع رساني مهلت پرداخت رزرو</summary>
            DeadLineReservePayLink = 4514
            ''' <summary>کنسلي رزرو قطعي داراي پرداخت</summary>
            ReserveCancelCost = 4515
            ''' <summary>کنسلي رزرو موقت داراي پرداخت</summary>
            TempReserveCancelCost = 4516
        End Enum

        ''' <summary>نوع محاسبه هزينه ها</summary>
        Public Enum CostCalculationType
            ''' <summary>فهرست بها</summary>
            PriceList = 2080
            ''' <summary>طبق قرارداد</summary>
            Contract = 2081
        End Enum

        ''' <summary>انواع منبع ضمائم</summary>
        Public Enum AttachmentReferenceType
            ''' <summary>رجيستر</summary>
            Register = 2090
            ''' <summary>رزرو</summary>
            Reserve = 2091
            ''' <summary>سند حسابداري</summary>
            Vouchers = 2092
            ''' <summary>گزارشات دايناميک چاپ</summary>
            Cheques = 2093
            ''' <summary>اتوماسيون اداري</summary>
            OfficeAutomation = 2094
            ''' <summary>سوابق تنبيهات</summary>
            Grueling = 2095
            ''' <summary>سوابق تشويقات</summary>
            Encouragement = 2096
            ''' <summary>مدارک دوره هاي آموزشي</summary>
            PeopleEducationDocument = 2097
            ''' <summary>برگه هاي انبار</summary>
            StoreDocuments = 2098
        End Enum

        ''' <summary>انواع تخفيف کارت اشتراک</summary>
        Public Enum DiscountPropertiesType
            ''' <summary>اقامت</summary>
            Room = 2134
            ''' <summary>رستوران</summary>
            Restaurant = 2135
            ''' <summary>کافي شاپ</summary>
            Teria = 2136
            ''' <summary>لاندري</summary>
            Landry = 2137
            ''' <summary>فروشگاه</summary>
            Shop = 2138
            ''' <summary>اسپا</summary>
            Spa = 2139
        End Enum

        ''' <summary>نوع مهمان</summary>
        Public Enum GuestAgeTypes
            ''' <summary>تمام بها</summary>
            FullCost = 2145
            ''' <summary>نيمه بها</summary>
            HalfCost = 2146
        End Enum

        ''' <summary>نوع تحويل صورتحساب</summary>
        Public Enum BillDeliveryType
            ''' <summary>فوري</summary>
            Fast = 2150
            ''' <summary>عادي</summary>
            Normal = 2151
        End Enum

        ''' <summary>نوع کارت شناسايي</summary>
        Public Enum IdentityCardTypes
            ''' <summary>کارت ملي</summary>
            NationalCard = 2155
            ''' <summary>شناسنامه</summary>
            Certificate = 2156
            ''' <summary>گواهينامه</summary>
            Diploma = 2157
            ''' <summary>پاسپورت</summary>
            Passport = 2158
            ''' <summary>سند ازدواج</summary>
            MarriageCertificate = 2159
            ''' <summary>دفترچه بيمه</summary>
            HealthInsuranceCard = 2160
            ''' <summary>پايان خدمت</summary>
            MilitaryCard = 2161
        End Enum

        ''' <summary>RegisterTransferانواع رکودهاي جدول</summary>
        Public Enum RegisterTransferType
            ''' <summary>بن نفر اضافه تمام بها</summary>
            ExtraFullPrint = 2165
            ''' <summary>بن نفر اضافه نيمه بها</summary>
            ExtraHalfPrint = 2166
            ''' <summary>بن نفراضافه زير سن محاسبه</summary>
            NotAccountingPrint = 2167
        End Enum

        ''' <summary>انواع تغييرات اطلاعات</summary>
        Public Enum ModifyType
            ''' <summary>اصلاح کاربر</summary>
            UserModify = 2210
            ''' <summary>رجيستر کارت</summary>
            RegisterCart = 2211
            ''' <summary>تعويض قرارداد</summary>
            ContractChange = 2212
            ''' <summary>تعويض اتاق</summary>
            RoomChange = 2213
        End Enum

        ''' <summary>وضعيت ميز</summary>
        Public Enum LocationStatus
            ''' <summary>خالي</summary>
            Free = 2220
            ''' <summary>در حال سفارش</summary>
            Enjoin = 2221
            ''' <summary>منتظر ثبت ميزبان</summary>
            WaitForSave = 2222
            ''' <summary>ثبت شده</summary>
            Saved = 2223
            ''' <summary>در حال سرو</summary>
            Eating = 2224
            ''' <summary>تخليه-در حال سرويس</summary>
            Checkout = 2225
            ''' <summary>پرداخت</summary>
            PayOff = 2226
        End Enum

        ''' <summary>نوع ايميل</summary>
        Public Enum EmailRowType
            ''' <summary>تاييديه رزرو</summary>
            Reserve = 2242
            ''' <summary>تسويه حساب رجيستر</summary>
            RegisterPayOff = 2243
            ''' <summary>تولد</summary>
            Birthday = 2244
            ''' <summary>رزرو خدمات</summary>
            EmailSend = 2245
            ''' <summary>ارسال ايميل بعد از ثبت مشترک</summary>
            EmailSendAfterSubscribeRegister = 2246
        End Enum

        ''' <summary>انواع گارانتي قرارداد</summary>
        Public Enum ContractGuaranteeTypes
            ''' <summary>اتاق</summary>
            Room = 2270
            ''' <summary>سالن</summary>
            Salon = 2271
            ''' <summary>غذا</summary>
            Food = 2272
            ''' <summary>ميان وعده</summary>
            Teria = 2273
            ''' <summary>ساير خدمات</summary>
            OtherService = 2274
        End Enum

        ''' <summary>انواع مشخصه قرارداد</summary>
        Public Enum ContractPropertyType
            ''' <summary>شارژ قرارداد</summary>
            ContarctCharge = 2290
            ''' <summary>تعداد شب اقامت براي شارژ رايگان</summary>
            NumberNightsFreeCharge = 2291
            ''' <summary>شماره سريال</summary>
            SerialNo = 2292
            ''' <summary>کارمزد</summary>
            Wage = 2960
        End Enum

        ''' <summary>انواع اطلاعات مشخصات هتل</summary>
        Public Enum HotelConfigurationType
            ''' <summary>نام هتل</summary>
            Title = 2380
            ''' <summary>نوع هتل</summary>
            Type = 2381
            ''' <summary>الياس</summary>
            Aliass = 2382
            ''' <summary>آدرس کامل</summary>
            Address = 2383
            ''' <summary>کد اقتصادي</summary>
            EconomicCode = 2384
            ''' <summary>شناسه ملي</summary>
            NationalID = 2385
            ''' <summary>شماره تلفن</summary>
            TelNo = 2386
            ''' <summary>کد پستي</summary>
            ZipCode = 2387
            ''' <summary>خلاصه آدرس</summary>
            MiniAddress = 2388
            ''' <summary>مسير فايل دارائي</summary>
            DaraieFilePath = 2389
            ''' <summary>شماره پرونده</summary>
            DocumentNumberTax = 2390
            ''' <summary>کد شعبه</summary>
            BranchCodeTax = 2391
            ''' <summary>نوع شخصيت پرداخت کننده حقوق</summary>
            PaymentType = 2392
            ''' <summary>نوع شخص حقوقي پرداخت کننده حقوق</summary>
            LegalEntityTypeTax = 2393
            ''' <summary>نام پرداخت کننده حقوق</summary>
            PaymentNameTax = 2394
            ''' <summary>نام خانوادگي پرداخت کننده حقوق / شرکت</summary>
            PaymentFamilyTax = 2395
            ''' <summary>نام شعبه</summary>
            BranchNameTax = 2396
            ''' <summary>شماره ملي صاحب امضاء مجاز-اول</summary>
            NationalCode1Tax = 2397
            ''' <summary>نام صاحب امضاء مجاز-اول</summary>
            Name1Tax = 2398
            ''' <summary>نام خانوادگي صاحب امضاءمجاز-اول</summary>
            Family1Tax = 2399
            ''' <summary>سمت صاحب امضاء مجاز-اول</summary>
            Post1Tax = 2410
            ''' <summary>شماره ملي صاحب امضاءمجاز-دوم</summary>
            NationalCode2Tax = 2411
            ''' <summary>نام صاحب امضاء مجاز-دوم</summary>
            Name2Tax = 2412
            ''' <summary>نام خانوادگي صاحب امضاء مجاز - دوم</summary>
            Family2Tax = 2413
            ''' <summary>سمت صاحب امضاء مجاز-دوم</summary>
            Post2Tax = 2414
            ''' <summary>آدرس لاتين هتل</summary>
            LatinAddressOfHotel = 2415
            ''' <summary>آدرس عربي هتل</summary>
            ArabicAddressOfHotel = 2416
            ''' <summary>نام استان</summary>
            Province = 2417
            ''' <summary>نام شهر</summary>
            City = 2418
        End Enum

        ''' <summary>درخواستهاي اتاق</summary>
        Public Enum RoomRequests
            ''' <summary>ورود به اتاق</summary>
            Checkin = 2400
            ''' <summary>مزاحم نشويد</summary>
            DoNotDistrub = 2401
            ''' <summary>درخواست نظافت</summary>
            MakeUp = 2402
            ''' <summary>درخواست لاندري</summary>
            LandryRequest = 2403
            ''' <summary>دماي اتاق</summary>
            Temperature = 2404
        End Enum

        ''' <summary>انواع قيمت گذاري کالا</summary>
        Public Enum GoodPriceingType
            ''' <summary>ميانگين</summary>
            Average = 2460
            ''' <summary>FIFO</summary>
            FIFO = 2461
            ''' <summary>LIFO</summary>
            LIFO = 2462
        End Enum

        ''' <summary>انواع قيمت تمام شده </summary>
        Public Enum CostControlType
            ''' <summary>حقوق و دستمزد</summary>
            Salary = 2500
            ''' <summary>استهلاک</summary>
            WearOff = 2501
            ''' <summary>هزينه سربار</summary>
            OverheadCost = 2502
        End Enum

        ''' <summary>انواع محلهاي قيمت تمام شده</summary>
        Public Enum CostControlPlaceType
            ''' <summary>اغذيه و اشربه - رستوران ها</summary>
            Restaurant = 2520
            ''' <summary>اغذيه و اشربه - کافي شاپ ها</summary>
            Teria = 2521
            ''' <summary>لاندري ها</summary>
            Landry = 2522
            ''' <summary>واحدهاي اقامتي</summary>
            Room = 2523
        End Enum

        ''' <summary>انواع مستندات انبار</summary>
        Public Enum StoreDocumentType
            ''' <summary>موجودي اول دوره</summary>
            PrimaryInventory = 2531
            ''' <summary>رسيد</summary>
            Receipt = 2532
            ''' <summary>حواله</summary>
            Draft = 2533
            ''' <summary>رسيد برگشتي</summary>
            ReturnReceipt = 2534
            ''' <summary>حواله انتقال</summary>
            TransferDraft = 2535
            ''' <summary>رسيد انتقال</summary>
            TransferReceipt = 2536
            ''' <summary>حواله کسورات</summary>
            DiductionDraft = 2537
            ''' <summary>رسيد اضافات</summary>
            ExtraReceipt = 2538
            ''' <summary>حواله مصرف مستقيم</summary>
            DraftDirectConsumption = 2539
            ''' <summary>رسيد مصرف مستقيم</summary>
            ReceiptDirectConsumption = 2540
            ''' <summary>حواله برگشت از خريد</summary>
            TurnBackDraft = 2541
            ''' <summary>حواله برگشت از انبارک</summary>
            TurnBackBinDraft = 2542
            ''' <summary>حواله تعديل</summary>
            DraftBalance = 2543
            ''' <summary>رسيد تعديل</summary>
            ReciptBalance = 2544
        End Enum

        ''' <summary>تنظيمات صبحانه</summary>
        Public Enum BreakfastSetting
            ''' <summary>دسته بن</summary>
            BillSerial = 2560
            ''' <summary>رستوران</summary>
            Resturant = 2561
            ''' <summary>غذاي صبحانه</summary>
            Food = 2562
            ''' <summary>حداکثر زمان استفاده</summary>
            MaxTime = 2563
            ''' <summary>بن صبحانه رايگان بر اساس نفرات رجيستر</summary>
            BreakfastByRegister = 2564
        End Enum

        ''' <summary>نوع درخواست کالا</summary>
        Public Enum GoodRequestType
            ''' <summary>درخواست کالا</summary>
            GoodRequest = 2580
            ''' <summary>درخواست خريد</summary>
            PurchaseRequest = 2581
            ''' <summary>درخواست شارژ انبار</summary>
            StoreChargeRequest = 2582
            ''' <summary>درخواست برگشت کالا</summary>
            TurnBackGoodRequest = 2583
            ''' <summary>درخواست برگشت از خريد</summary>
            TurnBackBuyRequest = 2584
        End Enum

        ''' <summary>انواع انبار گرداني</summary>
        Public Enum StoreHandlingTypes
            ''' <summary>ساليانه</summary>
            Yearly = 2590
            ''' <summary>طي دوره</summary>
            Period = 2591
            ''' <summary>تعديل انحراف</summary>
            AdjustedDeviation = 2592
        End Enum

        ''' <summary>نوع انبار</summary>
        Public Enum StoreTypes
            ''' <summary>انبار</summary>
            Store = 2600
            ''' <summary>انبارک</summary>
            Bin = 2601
        End Enum

        ''' <summary>نوع تحويل کالا</summary>
        Public Enum GoodDeliveryType
            ''' <summary>انبار</summary>
            Store = 2610
            ''' <summary>مستقيم</summary>
            Direct = 2611
        End Enum

        ''' <summary>وضعيت درخواست کالا</summary>
        Public Enum GoodRequestStatus
            ''' <summary>صدور درخواست</summary>
            IssueRequest = 2620
            ''' <summary>ابطال</summary>
            Revoke = 2621
            ''' <summary>تائيد نيازمندي</summary>
            VerificationRequirements = 2622
            ''' <summary>تائيد نهائي</summary>
            VerifyRequest = 2623
            ''' <summary>تصويب درخواست</summary>
            ApproveRequest = 2624
            ''' <summary>کنترل اعتبار</summary>
            CreditControl = 2625
            ''' <summary>کنترل موجودي</summary>
            StockControl = 2626
            ''' <summary>حواله موقت</summary>
            TemporaryDraft = 2627
            ''' <summary>تحويل کالا از انبار</summary>
            DeliveryFromStore = 2628
            ''' <summary>خريد مستقيم</summary>
            DirectPurchase = 2629
            ''' <summary>تحويل مستقيم</summary>
            DirectDelivery = 2630
            ''' <summary>خريد انباري</summary>
            StorePurchase = 2631
            ''' <summary>صف انتظار</summary>
            WaitingList = 2632
            ''' <summary>تحويل از خريد</summary>
            DeliveryOfPurchase = 2633
            ''' <summary>تحويل از صف انتظار</summary>
            DeliveryOfWaitingList = 2634
            ''' <summary>خريد از صف انتظار</summary>
            PurchaseOfWaitingList = 2635
            ''' <summary>تعيين فروشنده</summary>
            DifineSeller = 2636
        End Enum

        ''' <summary>وضعيت کالا</summary>
        Public Enum GoodStatus
            ''' <summary>نو</summary>
            [New] = 2660
            ''' <summary>مستعمل</summary>
            Old = 2661
        End Enum

        ''' <summary>نوع sqript</summary>
        Public Enum SgriptType
            ''' <summary>TABLE</summary>
            TABLE = 2680
            ''' <summary>ALTER TABLE</summary>
            ALTER_TABLE = 2681
            ''' <summary>DOMAIN</summary>
            DOMAIN = 2682
            ''' <summary>FUN</summary>
            FUN = 2683
            ''' <summary>SP</summary>
            SP = 2684
            ''' <summary>VIEW</summary>
            VIEW = 2685
            ''' <summary>OTHER</summary>
            OTHER = 2686
        End Enum

        ''' <summary>Delete شود-Recipe انواع</summary>
        Public Enum TypeOfRecipe
            ''' <summary>لاندري</summary>
            Landry = 2711
            ''' <summary>اغذيه و اشربه</summary>
            Food = 2712
            ''' <summary>ملزومات</summary>
            Supplies = 2713
        End Enum

        ''' <summary>انواع مشخصه هاي درخواست کالا</summary>
        Public Enum GoodRequestPropertyTypes
            ''' <summary>مبدا برگشت کالا</summary>
            ReturnSource = 2721
            ''' <summary>شناسه حواله برگشتي</summary>
            ReturnDraftID = 2722
            ''' <summary>انبارک حواله برگشتي</summary>
            ReturnBin = 2723
            ''' <summary>فروشنده برگشت از خريد</summary>
            ReturnPurchase = 2724
        End Enum

        ''' <summary>سطوح دستور کار مالي</summary>
        Public Enum AccountLevels
            ''' <summary>کل</summary>
            Level1 = 2730
            ''' <summary>معين</summary>
            Level2 = 2731
            ''' <summary>تفضيلي 1</summary>
            Level3 = 2732
            ''' <summary>تفضيلي 2</summary>
            Level4 = 2733
            ''' <summary>تفضيلي 3</summary>
            Level5 = 2734
            ''' <summary>تفضيلي4</summary>
            LEVEL6 = 2735
            ''' <summary>تفضيلي5</summary>
            LEVEL7 = 2736
        End Enum

        ''' <summary>وضعيت غذاهاي باقي مانده</summary>
        Public Enum StatusRemainFood
            ''' <summary>مصرف پرسنلي</summary>
            PersonelUsage = 2740
            ''' <summary>مصرف وعده بعدي</summary>
            NextMealUsage = 2741
            ''' <summary>مصرف رسيپي</summary>
            RecipeUsage = 2742
            ''' <summary>ساير</summary>
            OtherUsage = 2743
            ''' <summary>ضايعات</summary>
            WasteUsage = 2744
            ''' <summary>مصرف جاري</summary>
            CurrentUsage = 2745
        End Enum

        ''' <summary>انواع مشخصه هاي انبار</summary>
        Public Enum StorePropertyType
            ''' <summary>گروه هاي کالا</summary>
            GoodType = 2750
            ''' <summary>محل ارائه</summary>
            ConsumePlace = 2751
        End Enum

        ''' <summary>نوع حسابها</summary>
        Public Enum TypesOfAccounts
            ''' <summary>جاري</summary>
            CurrentAccount = 2760
            ''' <summary>سپرده</summary>
            SavingAccount = 2761
        End Enum

        ''' <summary>انواع چک</summary>
        Public Enum TypesOfCheques
            ''' <summary>چک خاص</summary>
            SpecialCheque = 2765
            ''' <summary>چک پول</summary>
            MoneyCheque = 2766
            ''' <summary>چک ضمانتي</summary>
            SponsorshipCheque = 2767
        End Enum

        ''' <summary>عمليات چک</summary>
        Public Enum OperationsOfCheques
            ''' <summary>دريافتي</summary>
            CurrentAccount = 2770
            ''' <summary>پرداختي</summary>
            SavingAccount = 2771
        End Enum

        ''' <summary>وضعيت چک</summary>
        Public Enum StatusOfCheques
            ''' <summary>فعال </summary>
            Active = 2775
            ''' <summary>صادرشده</summary>
            Issued = 2776
            ''' <summary>باطل شده</summary>
            Canceled = 2777
            ''' <summary>باطل شده-سند خورده</summary>
            CanceledDocumented = 2778
            ''' <summary>صادر شده- سند حساب پرداختني</summary>
            TemproryDocumented = 2779
            ''' <summary>عودت شده</summary>
            Returned = 2780
            ''' <summary>پاس شده</summary>
            DefiniteDocumented = 2781
            ''' <summary>Delete شده</summary>
            Deleted = 2782
            ''' <summary>اسناد نزد صندوق</summary>
            TheCash = 2783
            ''' <summary>اسناد نزد بانک</summary>
            TheBank = 2784
            ''' <summary>خرج شده</summary>
            Spent = 2910
            ''' <summary>برگشت خورده</summary>
            ReturnFromBank = 2911
        End Enum

        ''' <summary>تنظيمات پيام صوتي</summary>
        Public Enum AudioMessageSetting
            ''' <summary>نام کاربري</summary>
            UserName = 2785
            ''' <summary>رمز عبور</summary>
            Password = 2786
            ''' <summary>ارسال پيغام ورود ميهمان</summary>
            SendCheckinAudio = 2787
            ''' <summary>ارسال پيغام Exit ميهمان</summary>
            SendCheckOutAudio = 2788
            ''' <summary>ارسال پيغام روز اول اقامت ميهمان</summary>
            SendFirstResidentAudio = 2789
            ''' <summary>ارسال پيغام تاييديه رزرو</summary>
            SendReserveVerifyAudio = 2790
        End Enum

        ''' <summary>تنظيمات انبار و کاست کنترل</summary>
        Public Enum StoreAndCostControlSetting
            ''' <summary>تاريخ شروع کاست کنترل</summary>
            DateOfStartCostControl = 2796
            ''' <summary>ديتابيس فعال انبار</summary>
            StoreSysActiveDataBase = 2798
            ''' <summary>سرور و نام کاربري ديتابيس انبار</summary>
            StoreSysDataBaseIp = 2799
            ''' <summary>فعال سازي کارتابل</summary>
            ActiveKartable = 2800
            ''' <summary>حداقل طول کد کالا</summary>
            MinimumLengthProductCode = 2801
            ''' <summary>حداکثر طول کد کالا</summary>
            MaximumLengthProductCode = 2802
            ''' <summary>ويرايش درخواست ها همراه با رسيد/حواله</summary>
            EditRequestWithStoreDocuments = 2803
            ''' <summary>عدم ثبت تفصيلي انبار براي اسناد</summary>
            NotCertainRecordStores = 2804
            ''' <summary>ديتابيس انبار نرم افزار پايا</summary>
            DataBaseStockOfPAYA = 2805
            ''' <summary>ثبت مبلغ رسيدبدون ماليات</summary>
            PriceOfReceiptWithoutTax = 2806
            ''' <summary>کد انبار براي انتقال مصرف مستقيم</summary>
            CodeOfStoreForDirectConsumption = 2807
            ''' <summary>صدور سند رسيد همراه با حواله مستقيم</summary>
            CreateDocReceiptWithDraftDirectConsumption = 2930
            ''' <summary>صدوررسيد مستقيم براساس نوع تحويل کالا</summary>
            IssuingDirectReceiptWithDeliveryType = 2931
            ''' <summary>کدينگ مالي ماليات</summary>
            TaxAccCode = 2932
            ''' <summary>عدم بررسي کد فاکتور تکراري</summary>
            NotCheckDuplicateCodeFactor = 2933
            ''' <summary>نمايش شماره حواله در بدهکار سند گردش ريالي</summary>
            UseCodeDraftInDebitDocOfValuation = 2934
            ''' <summary>نمايش عنوان کالا در سند گردش ريالي انبار</summary>
            UseGoodTitleInStoreValuationDoc = 2935
            ''' <summary>نمايش عنوان کالا در سند رسيد انبار</summary>
            UseGoodTitleInStoreReciptDoc = 2936
            ''' <summary>ثبت صورت مجلس تحويل کالا</summary>
            UseParliamentDocumentGood = 2937
            ''' <summary>عدم کنترل وعده هاي غذايي در ثبت منو</summary>
            DontCheckCCIDInInsertMenu = 2938
            ''' <summary>عدم بسته شدن فرم ثبت رسيدوحواله پس از ثبت</summary>
            DontCloseFrmReceiptAndDraftAfterInsert = 2939
            ''' <summary>عدم ثبت مبالغ سرشکن در فاکتور</summary>
            DontRecordPriceProrateOfFactor = 2946
            ''' <summary>عدم ثبت حواله درخواست کالا پس از ثبت رسيد</summary>
            DontRecordDraftOfGoodRequestAfterReceipt = 2947
            ''' <summary>استفاده از منوي غذايي جديد</summary>
            UseNewFoodMenu = 2948
            ''' <summary>عدم انتقال مانده غذاي منوي جاري</summary>
            DontTransferFoodRemainQuantity = 2949
            ''' <summary>نمايش شماره فاکتوردر رديف سندو فروشنده در هدر سند</summary>
            ShowFactorCodeInDetailOfDocAndPurchase = 2955
            ''' <summary>نمايش تمامي کالاها در صدور سند رسيد</summary>
            ShowAllGoodsTitleInDocReceipt = 2956
            ''' <summary>سيستم کاست کنترل پيشرفته</summary>
            CostControlAdvanced = 2957
            ''' <summary>شناسه ي بن رستوران پرسنلي</summary>
            PeoIdPersonelUsage = 2958
            ''' <summary>نمايش تمامي کالاها در صدور سند حواله</summary>
            ShowAllGoodsTitleInDocDraft = 2959
            ''' <summary>صدور شماره رسيد/حواله سريال</summary>
            CodeOfStoreDocumentIsSerial = 2966
            ''' <summary>عدم نمايش موجودي انبار</summary>
            DontShowInventoryStore = 2967
            ''' <summary>کدينگ مالي تخفيف</summary>
            DiscountAccCode = 2969
            ''' <summary>صدور درخواست کالا همراه با کنترل موجودي</summary>
            IssuanceGoodRequestWithInventoryControl = 4325
            ''' <summary>آيا کنترل کالاهاي هر محل مصرف انجام شود</summary>
            CheckConsumePlaceGoods = 4326
            ''' <summary>ارسال خودکار چاپ حواله</summary>
            SendAutoPrintOfDraft = 4327
            ''' <summary>عدم بازشدن خودکارپنجره ي Select کالا</summary>
            DontOpenAutoWindowOfSelectGood = 4328
            ''' <summary>چاپ ته برگ موجودي اول دوره</summary>
            FooterPrimaryInventory = 4430
            ''' <summary>چاپ ته برگ رسيد انبار</summary>
            FooterReceipt = 4431
            ''' <summary>چاپ ته برگ حواله انبار</summary>
            FooterDraft = 4432
            ''' <summary>چاپ ته برگ رسيد برگشتي</summary>
            FooterReturnReceipt = 4433
            ''' <summary>چاپ ته برگ حواله انتقال</summary>
            FooterTransferDraft = 4434
            ''' <summary>چاپ ته برگ رسيد انتقال</summary>
            FooterTransferReceipt = 4435
            ''' <summary>چاپ ته برگ حواله کسورات</summary>
            FooterDiductionDraft = 4436
            ''' <summary>چاپ ته برگ رسيد اضافات</summary>
            FooterExtraReceipt = 4437
            ''' <summary>چاپ ته برگ فاکتور</summary>
            FooterFactor = 4438
            ''' <summary>چاپ ته برگ حواله برگشت از خريد</summary>
            FooterTurnBackDraft = 4439
            ''' <summary>چاپ ته برگ حواله برگشت از انبارک</summary>
            FooterTurnBackBinDraft = 4440
            ''' <summary>چاپ ته برگ حواله تعديل</summary>
            FooterDraftBalance = 4441
            ''' <summary>چاپ ته برگ رسيد تعديل</summary>
            FooterReciptBalance = 4442
            ''' <summary>آيا صدور سند به تفکيک انبار صادر شود ؟</summary>
            GenerateVoucherValuationGroupByStore = 4443
            ''' <summary>کدينگ عوارض شهرداري</summary>
            DuesAccCode = 4444
            ''' <summary>کدينگ ساير هزينه ها</summary>
            OtherPriceCode = 4445
            ''' <summary>کدينگ هزينه حمل</summary>
            CarryPriceCode = 4446
            ''' <summary>ثبت رسيپي بوفه در منوي غذايي</summary>
            AddRecipeOfBuffetToMenu = 4447
            ''' <summary>آيا هر کاربر تنها درخواستهاي کالاي مربوط به خود را ببيند ؟</summary>
            ShowOnlyUserRequestGood = 4448
        End Enum

        ''' <summary>نوع گروه حساب</summary>
        Public Enum AccountingGroupType
            ''' <summary>سود و زياني</summary>
            ProfitAndLoss = 2808
            ''' <summary>ترازنامه اي</summary>
            BalanceSheet = 2809
            ''' <summary>انتظامي</summary>
            Disciplinary = 2810
        End Enum

        ''' <summary>انواع پيام صوتي</summary>
        Public Enum AudioMessageType
            ''' <summary>ورود ميهمان</summary>
            CheckIn = 2820
            ''' <summary>Exit ميهمان</summary>
            CheckOut = 2821
            ''' <summary>روز اول اقامت ميهمان</summary>
            FirstResident = 2822
            ''' <summary>تاييديه رزرو</summary>
            ReserveVerify = 2823
            ''' <summary>متفرقه</summary>
            Others = 2824
        End Enum

        ''' <summary>تنظيمات PC POS</summary>
        Public Enum PcPosSetting
            ''' <summary>آدرس IP</summary>
            IpAdress = 2830
            ''' <summary>شناسه حساب پيش فرض</summary>
            DefualtBankAccountId = 2831
            ''' <summary>آدرس سرور</summary>
            ServerAddress = 2832
            ''' <summary>Token</summary>
            Token = 2833
        End Enum

        ''' <summary>مراکز کنترل هزينه</summary>
        Public Enum CostControlCenters
            ''' <summary>غذا و نوشابه</summary>
            CostFood = 2841
            ''' <summary>واحدهاي اقامتي</summary>
            CostRooms = 2842
            ''' <summary>لاندري</summary>
            CostLandry = 2843
            ''' <summary>تريا</summary>
            CostTeria = 2844
        End Enum

        ''' <summary>نوع سند چک</summary>
        Public Enum TypeOfDocCheque
            ''' <summary> حسابهاي موقت</summary>
            TemporaryAccount = 2870
            ''' <summary>  حسابهاي بانک</summary>
            BankAccount = 2871
        End Enum

        ''' <summary>انواع محتواي کارتابل</summary>
        Public Enum ContentType
            ''' <summary>درخواست کالا</summary>
            GoodRequest = 2876
            ''' <summary>سند حسابداري</summary>
            Vouchers = 2877
            ''' <summary>درخواست خريد</summary>
            PurchaseRequest = 2878
            ''' <summary>صورتحساب خريد</summary>
            PurchaseBill = 2879
            ''' <summary>صدوراسناد انبار</summary>
            IssuingStoreDoc = 2880
            ''' <summary>اتوماسيون اداري</summary>
            OfficeAutomation = 2881
            ''' <summary>چک</summary>
            Cheques = 2882
            ''' <summary>وجه نقد</summary>
            Money = 2883
            ''' <summary>درخواست نظرسنجي</summary>
            VoteRequest = 2884
            ''' <summary>دستورکار</summary>
            JobWorker = 2898
            ''' <summary>حواله</summary>
            Assignment = 2899
            ''' <summary>کارمزد/هزينه</summary>
            Cost = 2900
            ''' <summary>چک انتظامي</summary>
            Discipline = 2901
            ''' <summary>سفته</summary>
            Paper = 2902
            ''' <summary>درخواست خدمات</summary>
            ServiceRequest = 4500
        End Enum

        ''' <summary>نوع اقدام کارتابل</summary>
        Public Enum PerformType
            ''' <summary>ابطال</summary>
            Cancle = 2885
            ''' <summary>برگشت</summary>
            TurnBack = 2886
            ''' <summary>تاييد</summary>
            Verify = 2887
            ''' <summary>مشاهده شده</summary>
            Viewed = 2888
            ''' <summary>مشاهده نشده</summary>
            NotViewed = 2889
            ''' <summary>پايان گردش</summary>
            Finished = 2890
            ''' <summary>واگذار شده</summary>
            Transferred = 2891
            ''' <summary>معلق</summary>
            suspend = 2892
        End Enum

        ''' <summary>علت وضعيت چک</summary>
        Public Enum ReasonOfChequesStatus
            ''' <summary>مخدوش شده</summary>
            Altered = 2896
            ''' <summary>برگشت</summary>
            Returned = 2897
        End Enum

        ''' <summary>انواع ضمائم رديف سند</summary>
        Public Enum TypeOfContentsDocument
            ''' <summary>چک</summary>
            Cheque = 2906
            ''' <summary>فيش بانکي</summary>
            BankReceipt = 2907
        End Enum

        ''' <summary>سطوح دسترسي</summary>
        Public Enum AppendType
            ''' <summary>تهي</summary>
            None = 2940
            ''' <summary>حواله انبار</summary>
            Draft = 2941
            ''' <summary>رسيد انبار</summary>
            Receipt = 2942
            ''' <summary>صندوق</summary>
            Cash = 2943
            ''' <summary>حقوق و دستمزد</summary>
            Salary = 2945
            ''' <summary>چک</summary>
            Cheques = 3031
            ''' <summary>اموال</summary>
            Possession = 3032
        End Enum


        ''' <summary>انواع دوره هاي خدمات رزرو</summary>
        Public Enum ServiceCyclesType
            ''' <summary>تالار</summary>
            Talar = 2950
            ''' <summary>رستوران</summary>
            Resturant = 2951
            ''' <summary>عمومي</summary>
            General = 2952
        End Enum

        ''' <summary>نوع فرمول</summary>
        Public Enum SalaryFormulaType
            ''' <summary>حکم</summary>
            Agreement = 2970
            ''' <summary>حقوق</summary>
            Salary = 2971
        End Enum

        ''' <summary>نوع گروه فرمولها</summary>
        Public Enum SalaryFormulaGroup
            ''' <summary>مزايا</summary>
            Benefit = 2975
            ''' <summary>کسورات</summary>
            Deducts = 2976
            ''' <summary>امتياز</summary>
            Score = 2977
            ''' <summary>مشخصات</summary>
            Properties = 2978
        End Enum

        ''' <summary>نوع محاسبات فرمولهاي حقوق</summary>
        Public Enum SalaryFormulaCalculationType
            ''' <summary>محاسباتي</summary>
            Calculation = 2985
            ''' <summary>ثابت</summary>
            Constant = 2988
            ''' <summary>حکمي</summary>
            Prescription = 2989
        End Enum

        ''' <summary>وضعيت رزرو غذا</summary>
        Public Enum FoodReserveStatus
            ''' <summary>منو</summary>
            InList = 2986
            ''' <summary>مازاد</summary>
            ExtendedToList = 2987
        End Enum

        ''' <summary>نوع پرداختي</summary>
        Public Enum SalaryType
            ''' <summary>ماهيانه</summary>
            Monthly = 2990
            ''' <summary>خارج از ليست</summary>
            OffTheList = 2991
            ''' <summary>معوقه</summary>
            Delayed = 2992
        End Enum

        ''' <summary>نوع مقادير</summary>
        Public Enum ValueType
            ''' <summary>عدد</summary>
            IsInteger = 3000
            ''' <summary>رشته</summary>
            IsString = 3001
            ''' <summary>بله/خير</summary>
            IsBoolean = 3002
            ''' <summary>عددي بزرگ</summary>
            IsLong = 3003
            ''' <summary>اعشار</summary>
            IsDouble = 3004
        End Enum

        ''' <summary>نوع کنترل</summary>
        Public Enum ControlType
            ''' <summary>TextBox</summary>
            TextBox = 3005
            ''' <summary>ComboBox</summary>
            ComboBox = 3006
            ''' <summary>CheckBox</summary>
            CheckBox = 3007
        End Enum

        ''' <summary>انواع نامه ها</summary>
        Public Enum LetterType
            ''' <summary>درون سازماني</summary>
            InOffice = 3008
            ''' <summary>وارده</summary>
            ComerLetter = 3009
            ''' <summary>صادره</summary>
            OuterLetter = 3010
        End Enum

        ''' <summary>نوع مشخصه چک</summary>
        Public Enum ChequesPropertyType
            ''' <summary>سند</summary>
            Voucher = 3011
            ''' <summary>طرف مقابل</summary>
            Beside = 3012
            ''' <summary>تاريخچه</summary>
            History = 3013
        End Enum

        ''' <summary>انواع صدور درخواست</summary>
        Public Enum RequestType
            ''' <summary>درخواست صدور چک</summary>
            IssueChequesRequest = 3014
            ''' <summary>درخواست برداشت وجه</summary>
            ConceptionMoneyRequest = 3015
            ''' <summary>درخواست مرخصي روزانه</summary>
            DayOffRequest = 3016
            ''' <summary>درخواست مرخصي ساعتي</summary>
            HourOffRequest = 3017
            ''' <summary>درخواست اضافه کار ساعتي </summary>
            HourOverTimeRequest = 3018
            ''' <summary>درخواست مرخصي استعلاجي</summary>
            DayOffDemandRequest = 4220
            ''' <summary>درخواست ماموريت روزانه</summary>
            DailydutyRequests = 4221
            ''' <summary>درخواست ماموريت ساعتي</summary>
            HourDutyRequests = 4222
            ''' <summary>درخواست صدور حواله</summary>
            AssignmentRequest = 4223
            ''' <summary>درخواست صدور کارمزد/هزينه</summary>
            CostRequest = 4224
            ''' <summary>درخواست صدور چک انتظامي</summary>
            DisciplineRequest = 4225
            ''' <summary>درخواست صدور سفته</summary>
            PaperRequest = 4226
        End Enum

        ''' <summary>وضعيت درخواست</summary>
        Public Enum RequestStatus
            ''' <summary>درحال گردش</summary>
            InReferral = 3019
            ''' <summary>پايان گردش</summary>
            EndReferral = 3020
            ''' <summary>درخواست</summary>
            Request = 3021
            ''' <summary>ابطال</summary>
            Cancle = 3022
        End Enum

        ''' <summary>انواع فاکتور انبار</summary>
        Public Enum TypeOfFactors
            ''' <summary>فاکتور خريد</summary>
            PurchaseInvoice = 3040
            ''' <summary>فاکتور برگشت</summary>
            FactorBack = 3041
        End Enum

        ''' <summary>تنظيمات اسپا سنتر</summary>
        Public Enum SpaSetting
            ''' <summary>مدت زمان اوليه آزاد(دقيقه)</summary>
            SpaenterTime = 3060
            ''' <summary>مدت زمان اوليه ميهمانان(دقيقه)</summary>
            SpaEnterTimeGuest = 3061
        End Enum

        ''' <summary>انواع صورتحساب ها</summary>
        Public Enum BillSubType
            ''' <summary>عمومي</summary>
            General = 3081
            ''' <summary>قرارداد-مديران</summary>
            Contract_Management = 3082
            ''' <summary>قرارداد-مراسم</summary>
            Contract_Ceremony = 3083
            ''' <summary>قرارداد-کارکنان</summary>
            Contract_Personely = 3084
            ''' <summary>پرسنلي</summary>
            Personely = 3085
            ''' <summary>ستاد</summary>
            professor = 3086
            ''' <summary>غذاي پرسنلي تالار</summary>
            PersonelyTalar = 3087
            ''' <summary>سايرموارد</summary>
            Others = 3088
            ''' <summary>شرکتي</summary>
            OtherContract = 3089
            ''' <summary>موسسات</summary>
            Institute = 3090
        End Enum

        ''' <summary>درگاه هاي پرداخت اينترنتي</summary>
        Public Enum InternetPaymentPorts
            ''' <summary>سامان</summary>
            Saman = 3100
            ''' <summary>کشاورزي</summary>
            Keshavarzi = 3101
            ''' <summary>اقتصاد نوين</summary>
            EghtesadNovin = 3102
            ''' <summary>پارسيان</summary>
            Parsiyan = 3103
            ''' <summary>صادرات</summary>
            Saderat = 3104
            ''' <summary>ملي</summary>
            Melli = 3105
            ''' <summary>ملت</summary>
            Mellat = 3106
            ''' <summary>دي</summary>
            Dey = 3107
            ''' <summary>فن آوا کارت</summary>
            FanAva = 3108
            ''' <summary>مبناکارت</summary>
            Mabna = 3109
            ''' <summary>پاسارگاد</summary>
            Pasargad = 3110
            ''' <summary>ايران کيش</summary>
            IranKish = 3111
        End Enum

        ''' <summary>سيستم هاي درخواست کننده PcPos</summary>
        Public Enum PcPosApplicantSystems
            ''' <summary>صورتحساب</summary>
            Bill = 3121
            ''' <summary>اتاق هاي رجيسترکارت</summary>
            RegisterRoom = 3122
            ''' <summary>پارکينگ</summary>
            Parking = 3123
            ''' <summary>صندوق</summary>
            CashRegister = 3124
        End Enum

        ''' <summary>نوع مرتب سازي</summary>
        Public Enum TypeOfSort
            ''' <summary>براساس ثبت کردن</summary>
            SortByRegister = 3130
            ''' <summary>براساس کد</summary>
            SortByCode = 3131
            ''' <summary>براساس عنوان</summary>
            SortByTitle = 3132
        End Enum

        ''' <summary>وضعيت پرداخت PCPOS</summary>
        Public Enum PcPosPaymentStatus
            ''' <summary>فعال</summary>
            Active = 3140
            ''' <summary>آماده پرداخت</summary>
            ReadyPayment = 3141
            ''' <summary>پرداخت شده</summary>
            Paymented = 3142
            ''' <summary>قطعي</summary>
            Definite = 3143
            ''' <summary>منقضي شده</summary>
            Expired = 3144
            ''' <summary>غيرفعال</summary>
            DeActive = 3145
        End Enum

        ''' <summary>انواع گروه بندي کالا</summary>
        Public Enum TypeOfGoods
            ''' <summary>کالاي انبار</summary>
            GoodOfStore = 3150
            ''' <summary>گروه کالا</summary>
            GroupOfGood = 3151
            ''' <summary>کالاي کاست کنترل</summary>
            GoodOfCostControl = 3152
        End Enum

        ''' <summary>نحوه پرداخت جديد</summary>
        Public Enum NewPayType
            ''' <summary>هيچ</summary>
            None = 3160
            ''' <summary>نقد</summary>
            Cash = 3161
            ''' <summary>دستگاه Pos</summary>
            Pos = 3162
            ''' <summary>فيش بانکي</summary>
            BankFish = 3163
            ''' <summary>اينترنتي</summary>
            Enternet = 3164
            ''' <summary>چک</summary>
            Cheque = 3165
            ''' <summary>کارت به کارت</summary>
            CartToCart = 3166
        End Enum

        ''' <summary>انواع صورت هاي مالي</summary>
        Public Enum FinancialStatementsTypes
            ''' <summary>ترازنامه</summary>
            BalanceSheets = 3167
            ''' <summary>صورت سود و زيان</summary>
            ProfitAndLossStatement = 3168
            ''' <summary>صورت جريان وجوه نقد</summary>
            CashFlowStatements = 3169
            ''' <summary>صورت سود و زيان جامع</summary>
            ComprehensiveProfitAndLossAccount = 3170
        End Enum

        ''' <summary>انواع ماهيت صورت هاي مالي</summary>
        Public Enum FinancialStatementsNature
            ''' <summary>افزاينده</summary>
            Incremental = 3171
            ''' <summary>کاهنده</summary>
            Decremental = 3172
            ''' <summary>دارايي</summary>
            Assets = 3173
            ''' <summary>بدهي</summary>
            Liability = 3174
            ''' <summary>حقوق مالک</summary>
            Owner 'sEquity=3175
        End Enum

        ''' <summary>انواع مشخصه هاي سرشکن حساب ها</summary>
        Public Enum VariousTypesProrateAccount
            ''' <summary>حساب هاي مبداء</summary>
            SourceAccounts = 3183
            ''' <summary>حساب هاي مقصد</summary>
            DestinationAccounts = 3184
        End Enum

        ''' <summary>نحوه ي محاسبه سرشکن حسابها</summary>
        Public Enum CalculateAccounts
            ''' <summary>عملکرد</summary>
            Performance = 3185
        End Enum

        ''' <summary>انواع وضعيت برگه هاي انبار</summary>
        Public Enum TypeOfStatusStoreDocument
            ''' <summary>قطعي</summary>
            Definite = 3190
            ''' <summary>ابطال</summary>
            Cancel = 3191
            ''' <summary>موقت</summary>
            Temporary = 3192
            ''' <summary>Delete</summary>
            Delete = 3193
            ''' <summary>قابل ويرايش</summary>
            Editable = 3194
            ''' <summary>ريالي بدون مبلغ</summary>
            NoPrice = 3195
        End Enum

        ''' <summary>وضعيت نامه</summary>
        Public Enum LetterStatus
            ''' <summary>درگردش</summary>
            InReferral = 3200
            ''' <summary>مينوت</summary>
            Draft = 3201
            ''' <summary>ثبت شده</summary>
            Saved = 3202
        End Enum

        ''' <summary>سوابق پرسنل</summary>
        Public Enum PeopleHistory
            ''' <summary>سابقه سنوات</summary>
            SanavatHistory = 3301
            ''' <summary>ارزيابي سالانه</summary>
            YearlyEvaluation = 3302
            ''' <summary>انقطاع خدمت</summary>
            DisEmployee = 3303
            ''' <summary>دوره هاي آموزشي</summary>
            EducationalCourse = 3304
            ''' <summary>خارج سازمان</summary>
            ExternalEmployee = 3305
            ''' <summary>سابقه سربازي</summary>
            MiliarityHistory = 3306
            ''' <summary>مدارک تحصيلي</summary>
            StudyHistory = 3307
            ''' <summary>سوابق جذب</summary>
            AbsorbScore = 3308
            ''' <summary>سوابق گروه پرسنل</summary>
            GradeHistory = 3309
            ''' <summary>کارانه</summary>
            Efficiency = 3310
            ''' <summary>بسيج</summary>
            Mobilization = 3311
            ''' <summary>سوابق تنبيهات</summary>
            Grueling = 3312
            ''' <summary>سوابق تشويقات</summary>
            encouragement = 3313
        End Enum

        ''' <summary>مقاطع تحصيلي</summary>
        Public Enum StudyLevel
            ''' <summary>ديپلم</summary>
            Diplom = 3501
            ''' <summary>فوق ديپلم</summary>
            ExtraDiplom = 3502
            ''' <summary>ليسانس</summary>
            Lisance = 3503
            ''' <summary>فوق ليسانس</summary>
            ExtraLisance = 3504
            ''' <summary>دکترا</summary>
            doctora = 3505
        End Enum

        ''' <summary>درجه نياز</summary>
        Public Enum NecessaryDegree
            ''' <summary>درجه نياز 1</summary>
            Necessary1 = 3601
            ''' <summary>درجه نياز 2</summary>
            Necessary2 = 3602
            ''' <summary>درجه نياز 3</summary>
            Necessary3 = 3603
            ''' <summary>درجه نياز 4</summary>
            Necessary4 = 3604
        End Enum

        ''' <summary>نوع قرارداد رزرو خدمات</summary>
        Public Enum ContractTypeReserve
            ''' <summary>قرارداد شخصي</summary>
            PersonContract = 3401
            ''' <summary>قرارداد شرکتي</summary>
            SocietyContract = 3402
        End Enum

        ''' <summary>نوع فرمول حکم</summary>
        Public Enum PrescriptionFormulaType
            ''' <summary>ورود اطلاعات</summary>
            EnteringData = 3701
            ''' <summary>محاسباتي</summary>
            Calculating = 3702
        End Enum

        ''' <summary>گروه بندي اطلاعات حکم</summary>
        Public Enum PrescriptionFormulaGroups
            ''' <summary>سوابق</summary>
            History = 3801
            ''' <summary>امتيازات</summary>
            Point = 3802
            ''' <summary>حقوق</summary>
            Salary = 3803
        End Enum

        ''' <summary>سيستم</summary>
        Public Enum SubSystem
            ''' <summary>سيستم احکام</summary>
            PrescriptionsSystem = 3901
            ''' <summary>سيستم حقوق و دستمزد</summary>
            SalarySystem = 3902
        End Enum

        ''' <summary>کيفيت آموزشي</summary>
        Public Enum EducationQuality
            ''' <summary>نياز يک</summary>
            Necc1 = 4001
            ''' <summary>نياز دو</summary>
            Necc2 = 4002
            ''' <summary>خوب</summary>
            Good = 4003
            ''' <summary>خيلي خوب</summary>
            VeryGood = 4004
        End Enum

        ''' <summary>نوع پرسنل</summary>
        Public Enum PERSONNEL_TYPE
            ''' <summary>کارگر</summary>
            Worker = 4011
            ''' <summary>کارمند</summary>
            Personnel = 4012
            ''' <summary>قراردادي</summary>
            Contract = 4013
        End Enum

        ''' <summary>زبان اصلي</summary>
        Public Enum MainLaguage
            ''' <summary>زبان اصلي فرانسه - انگليسي</summary>
            Main = 4020
            ''' <summary>ساير زبانها</summary>
            Other = 4021
        End Enum

        ''' <summary>بخش شغلي</summary>
        Public Enum Job_Section
            ''' <summary>درگردش</summary>
            InReferral = 4100
            ''' <summary>10000</summary>
            Section10000 = 4101
            ''' <summary>20000</summary>
            Section20000 = 4102
            ''' <summary>30000</summary>
            Section30000 = 4103
            ''' <summary>40000</summary>
            Section40000 = 4104
            ''' <summary>50000</summary>
            Section50000 = 4105
            ''' <summary>60000</summary>
            Section60000 = 4106
            ''' <summary>80000</summary>
            Section80000 = 4107
        End Enum

        ''' <summary>درجه تسلط</summary>
        Public Enum GripeDegree
            ''' <summary>آشنايي کافي</summary>
            Enough = 4200
            ''' <summary>آشنايي کامل</summary>
            Complete = 4201
            ''' <summary>خوب</summary>
            Good = 4202
        End Enum

        ''' <summary>نوع عملکرد مشترکين</summary>
        Public Enum Subscribe_Operation_Type
            ''' <summary>اول دوره</summary>
            Primery = 4210
            ''' <summary>کسب شده</summary>
            Earned = 4211
            ''' <summary>استفاده شده</summary>
            Used = 4212
            ''' <summary>افزايش امتياز</summary>
            Increase = 4213
            ''' <summary>کاهش امتياز</summary>
            Decrease = 4214
        End Enum

        ''' <summary>نوع استخدام پرسنل</summary>
        Public Enum PeopleEmploymentType
            ''' <summary>کارگر</summary>
            Worker = 4230
            ''' <summary>کارمند</summary>
            Employee = 4231
            ''' <summary>قراردادي</summary>
            Contract = 4235
        End Enum

        ''' <summary>وضعيت تاهل</summary>
        Public Enum MaritalStatus
            ''' <summary>مجرد</summary>
            _SINGLE = 4232
            ''' <summary>متاهل</summary>
            MARRIAGE = 4233
            ''' <summary>متارکه</summary>
            DIVORCE = 4234
        End Enum

        ''' <summary>نوع ورود اطلاعات کدينگ</summary>
        Public Enum AccountItemType
            ''' <summary>ورود داده</summary>
            EnterringData = 50212
            ''' <summary>سيستمي</summary>
            System = 50213
        End Enum

        ''' <summary>پارامترهاي متغير سيستمي احکام</summary>
        Public Enum PrescriptionParameterSystem
            ''' <summary>دامنه امتيازات سنوات خدمت </summary>
            LaborCode = 4241
            ''' <summary>امتياز شغلي</summary>
            JobPointSystem = 4242
        End Enum

        ''' <summary>جداول سيستمي مالي</summary>
        Public Enum AccountTableSystems
            ''' <summary>پرسنلي</summary>
            PERSONNEL = 4260
            ''' <summary>شرکتي</summary>
            CONTRACT = 4261
            ''' <summary>انبارها</summary>
            STORE = 4262
            ''' <summary>آژانس ها</summary>
            Agency = 4263
            ''' <summary>فروشندگان</summary>
            Seller = 4264
            ''' <summary>صندوق - موجودي اول دوره</summary>
            ImprestInitBalance = 4266
            ''' <summary>تنخواه - موجودي اول دوره</summary>
            CashInitBalance = 4267
            ''' <summary>بانک -موجودي اول دوره</summary>
            BankInitBalance = 4296
        End Enum

        ''' <summary>انواع آيتم هاي خزانه داري</summary>
        Public Enum BursaryType
            ''' <summary>چک</summary>
            Cheques = 4265
            ''' <summary>انتظامي</summary>
            Discipline = 4268
            ''' <summary>حواله</summary>
            Assignment = 4269
            ''' <summary>هزينه </summary>
            Cost = 4270
            ''' <summary>درآمد</summary>
            Income = 4271
            ''' <summary>سود بانکي</summary>
            BenefitBank = 4319
            ''' <summary>فيش نقدي</summary>
            MoneyFish = 4320
            ''' <summary>دستگاه Pos</summary>
            Pos = 4321
            ''' <summary>قبوض</summary>
            Bills = 4322
            ''' <summary>سفته</summary>
            Paper = 4323
            ''' <summary>اوراق بهادار</summary>
            PortFolio = 4324
        End Enum

        ''' <summary>انواع کدينگهاي بانک</summary>
        Public Enum BankAccountCode
            ''' <summary>حساب اصلي بانک</summary>
            Bank = 4272
            ''' <summary>اسناد پرداختني</summary>
            Pay = 4273
            ''' <summary>اسناد دريافتني</summary>
            Recieve = 4274
        End Enum

        ''' <summary>انواع مشخصه هاي کالا</summary>
        Public Enum GoodProperties
            ''' <summary>واحد فرعي</summary>
            SecondaryUnit = 4280
            ''' <summary>برند</summary>
            Brand = 4281
            ''' <summary>ارتباط کالاي کاست و انبار</summary>
            CostRelationToGood = 4282
        End Enum

        ''' <summary>انواع استهلاک گيري</summary>
        Public Enum PossessionWearOffType
            ''' <summary>مستقيم</summary>
            Direct = 4290
            ''' <summary>نزولي</summary>
            Descending = 4291
        End Enum

        ''' <summary>انواع اموال</summary>
        Public Enum PossessionType
            ''' <summary>اموال</summary>
            Possession = 4293
            ''' <summary>ابزار</summary>
            Tools = 4294
            ''' <summary>اموال مصرفي</summary>
            Consumable = 4295
        End Enum

        ''' <summary>انواع وضعيت اموال</summary>
        Public Enum PossessionStatus
            ''' <summary>فعال</summary>
            Active = 4300
            ''' <summary>اسقاط</summary>
            Escape = 4301
            ''' <summary>مفقود</summary>
            Lost = 4302
        End Enum

        ''' <summary>انواع دليل استهلاک اموال</summary>
        Public Enum PossessionWearOffReason
            ''' <summary>استهلاک ساليانه</summary>
            Yearly = 4310
            ''' <summary>اسقاط</summary>
            Escape = 4311
            ''' <summary>برکناري</summary>
            Dismiss = 4312
            ''' <summary>مفقودي</summary>
            Lost = 4313
            ''' <summary>ماهيانه</summary>
            Monthly = 4314
        End Enum

        ''' <summary>انواع وابستگي فهرست بها</summary>
        Public Enum PriceListDependencyType
            ''' <summary>درصدي</summary>
            Percenty = 4330
            ''' <summary>تفاوت قيمت</summary>
            Price = 4331
            ''' <summary>فرمول</summary>
            Formula = 4332
        End Enum

        ''' <summary>موجودي اول دوره خزانه داري</summary>
        Public Enum AccountInitialBalanceType
            ''' <summary>بانک</summary>
            Bank = 4340
            ''' <summary>تنخواه</summary>
            Imprest = 4341
            ''' <summary>صندوق</summary>
            Cash = 4342
        End Enum

        ''' <summary>نوع قيمت گذاري اسناد انبار</summary>
        Public Enum StoreDocumentPriceingTypes
            ''' <summary>ميانگين</summary>
            Average = 4350
            ''' <summary>ثابت</summary>
            Fixed = 4351
            ''' <summary>آخرين قيمت خريد</summary>
            LastPurchasePrice = 4352
            ''' <summary>فهرست بها</summary>
            PriceList = 4353
        End Enum

        ''' <summary>انواع پاسخ</summary>
        Public Enum ResponseType
            ''' <summary>Selectي</summary>
            Selective = 604
            ''' <summary>تشريحي</summary>
            Anatomical = 605
        End Enum

        ''' <summary>نوع پاسخ Selectي</summary>
        Public Enum SelectiveResponseType
            ''' <summary>يکتا-کشويي</summary>
            Unique_Combo = 606
            ''' <summary>چندگانه-چک ليست</summary>
            Multiple_Checklist = 607
            ''' <summary>يکتا-دکمه راديويي</summary>
            Unique_Radio = 614
        End Enum

        ''' <summary>نوع فرم</summary>
        Public Enum FormType
            ''' <summary>نظرسنجي</summary>
            Survey = 608
            ''' <summary>شکايت</summary>
            Complaint = 609
            ''' <summary>چک ليست</summary>
            CheckList = 610
        End Enum

        ''' <summary>مخاطب</summary>
        Public Enum Audiance
            ''' <summary>ميهمان غيرمقيم</summary>
            Guest_NoneResiding = 611
            ''' <summary>پرسنل</summary>
            People = 612
            ''' <summary>متفرقه</summary>
            Other = 613
            ''' <summary>ميهمان مقيم</summary>
            Guest_Residing = 615
            ''' <summary>آژانس ها</summary>
            Contractors = 616
        End Enum

        ''' <summary>انواع نحوه صدور سند</summary>
        Public Enum TypesOfDocumentIssuance
            ''' <summary>به تفکيک</summary>
            Divided = 4360
            ''' <summary>سرجمع </summary>
            GROUPED = 4361
        End Enum

        ''' <summary>انواع اطلاعات در شرح سند انبار</summary>
        Public Enum FieldsOfStoreVoucher
            ''' <summary>شماره سند </summary>
            StoreDocumentCode = 4366
            ''' <summary>تاريخ سند </summary>
            StoreDocumentDate = 4367
            ''' <summary>نوع سند</summary>
            StoreDocumentType = 4368
            ''' <summary>عنوان انبار</summary>
            StoreTitle = 4369
            ''' <summary>عنوان گروه کالا</summary>
            GoodTypeTitle = 4370
            ''' <summary>عنوان کالا</summary>
            GoodTitle = 4371
            ''' <summary>شماره فاکتور</summary>
            FactorCode = 4372
            ''' <summary>تاريخ فاکتور</summary>
            FactorDate = 4373
            ''' <summary>محل مصرف</summary>
            ConsumePlace = 4374
            ''' <summary>نام فروشنده</summary>
            SellerName = 4375
            ''' <summary>نوع سند مرتبط</summary>
            ParentStoreDocumentCode = 4376
            ''' <summary>تاريخ سند مرتبط</summary>
            ParentStoreDocumentDate = 4377
            ''' <summary>شماره سند مرتبط</summary>
            ParentStoreDocumentType = 4378
            ''' <summary>نام تنخواه دار</summary>
            BuyerName = 4379
            ''' <summary>عنوان کد مالي</summary>
            AccTitle = 4380
        End Enum

        ''' <summary>انواع شرح اسناد انبار</summary>
        Public Enum StoreVoucherTemplates
            ''' <summary>طرف بدهکار رسيد</summary>
            ReceiptDebit = 4400
            ''' <summary>طرف بستانکار فروشنده</summary>
            ReceiptCellerCredit = 4401
            ''' <summary>طرف بستانکار تنخواه دار</summary>
            ReceiptBuyerCredit = 4420
            ''' <summary>طرف بدهکار تنخواه دار</summary>
            ReceiptBuyerDebit = 4421
        End Enum

        ''' <summary>نوع داده پاسخ تشريحي</summary>
        Public Enum ResponseDescType
            ''' <summary>عددي</summary>
            Numeric = 620
            ''' <summary>متن-تک خطي</summary>
            Text_OnlyLine = 621
            ''' <summary>متن-چند خطي</summary>
            Text_MultiLine = 622
        End Enum

        ''' <summary>انواع نگهداري تجهيز</summary>
        Public Enum MaintenanceTypes
            ''' <summary>سرويس</summary>
            Service = 4470
            ''' <summary>تعويض</summary>
            Change = 4471
            ''' <summary>بازديد</summary>
            Visit = 4472
            ''' <summary>چک ليست</summary>
            CheckList = 4473
        End Enum

        ''' <summary>انواع دوره نگهداري</summary>
        Public Enum DurationTypes
            ''' <summary>کارکرد</summary>
            Functional = 4480
            ''' <summary>ساعتي</summary>
            Hourly = 4481
            ''' <summary>روزانه</summary>
            Daily = 4482
        End Enum

        ''' <summary>نوع ثبت رسيد</summary>
        Public Enum ReceiptType
            ''' <summary>ثبت ريالي رسيد </summary>
            PriceType = 4490
            ''' <summary>ثبت مقداري رسيد</summary>
            ValueType = 4491
            ''' <summary>ثبت مقداري/ريالي رسيد</summary>
            PriceValueTtpe = 4492
        End Enum

        ''' <summary>انواع فصل</summary>
        Public Enum SeasonType
            ''' <summary>L</summary>
            L = 4390
            ''' <summary>H</summary>
            H = 4391
            ''' <summary>S</summary>
            S = 4392
            ''' <summary>HP</summary>
            HP = 4393
        End Enum

        ''' <summary>انواع مشخصه هاي اتاق هاي رجيستر شده</summary>
        Public Enum RegisterRoomProperty
            ''' <summary>درخواست مزاحم نشويد</summary>
            DoNotDisturb = 4410
            ''' <summary>پايان درخواست مزاحم نشويد</summary>
            EndOfDoNotDisturb = 4411
            ''' <summary>درخواست نظافت</summary>
            CleanUpRoom = 4412
            ''' <summary>پايان درخواست نظافت</summary>
            EndOfCleanUpRoom = 4413
            ''' <summary>درخواست لاندري</summary>
            Landry = 4414
            ''' <summary>پايان درخواست لاندري</summary>
            EndOfLandry = 4415
            ''' <summary>توضيحات تخليه رجيسترکارت</summary>
            CheckoutDescription = 4416
        End Enum

        ''' <summary>وضعيت درخواست</summary>
        Public Enum ServiceRequestStatus
            ''' <summary>درحال اجرا</summary>
            InProcess = 4530
            ''' <summary>اجرا شده</summary>
            Done = 4531
            ''' <summary>صدور</summary>
            IssueServiceRequest = 4532
            ''' <summary>تاييد</summary>
            Confirm = 4533
            ''' <summary>برنامه ريزي و اجرا</summary>
            Planning = 4534
            ''' <summary>پايان</summary>
            EndOfServiceRequest = 4535
        End Enum

        ''' <summary>تنظيمات اندازه رک</summary>
        Public Enum RackSizeSetting
            ''' <summary>اندازه فرم</summary>
            FormSize = 1973
            ''' <summary>سلولهاي رک</summary>
            CelSize = 1974
            ''' <summary>تصوير اتاق</summary>
            RoomImage = 1975
            ''' <summary>آرم شرکت</summary>
            Contractor = 1976
            ''' <summary>پيغام</summary>
            Message = 1977
            ''' <summary>يادداشتها</summary>
            Notification = 1978
            ''' <summary>صورتحساب باز</summary>
            OpenBill = 1979
            ''' <summary>Vip</summary>
            Vip = 1980
        End Enum

        ''' <summary>انواع Recipe </summary>
        Public Enum RecipiTypes
            ''' <summary>رستوران</summary>
            Resturent = 4250
            ''' <summary>تالار</summary>
            Talar = 4251
            ''' <summary>کافي شاپ</summary>
            Teria = 4252
            ''' <summary>لاندري</summary>
            Landry = 4253
        End Enum

        ''' <summary>انواع وضعيت Exit کالا و اموال</summary>
        Public Enum GoodExitStatus
            ''' <summary>خارج شده</summary>
            Exited = 13090
            ''' <summary>تحويل داده شده</summary>
            Returned = 13091
            ''' <summary>Delete شده</summary>
            Deleted = 13093
        End Enum

        ''' <summary>غذا و نوشابه</summary>
        Public Enum CostFood
            ''' <summary>رستوران ها</summary>
            Restaurant = 2851
            ''' <summary>آشپزخانه ها</summary>
            Kitchen = 2853
        End Enum

        ''' <summary>تريا</summary>
        Public Enum CostTeria
            ''' <summary>کافي شاپ ها</summary>
            CaffeShop = 2852
        End Enum


    End Class
    Public Enum Domains
        ''' <summary>انواع شهرها</summary>
        CityType = 8
        ''' <summary>جنسيت</summary>
        Gender = 9
        ''' <summary>انواع مردم</summary>
        PeopleType = 10
        ''' <summary>انواع دسته بن</summary>
        BillSerialType = 11
        ''' <summary>وضعيتهاي رجيسترکارت</summary>
        RegisterStatus = 12
        ''' <summary>وضعيتهاي اتاقهاي رجيسترکارت</summary>
        RegisterRoomStatus = 13
        ''' <summary>وضعيتهاي اتاق مهمانان رجيسترکارت</summary>
        RegisterRoomGuestStatus = 14
        ''' <summary>وضعيتهاي مهمانان رجيسترکارت</summary>
        RegisterGuestStatus = 15
        ''' <summary>وضعيتها</summary>
        Status = 16
        ''' <summary>انواع مهمانان رجيستر</summary>
        RegisterGuestType = 17
        ''' <summary>انواع شرکتها</summary>
        ContractorType = 18
        ''' <summary>نحوه پرداخت</summary>
        PayType = 19
        ''' <summary>نوع سرويس رستوران</summary>
        FoodServiceType = 20
        ''' <summary>وضعيت صورتحسابها</summary>
        BillStatus = 21
        ''' <summary>انواع سرويس ها</summary>
        ServiceType = 22
        ''' <summary>انواع خصوصيات رجيستر</summary>
        RegisterPropertyType = 23
        ''' <summary>انواع خصوصيات افراد</summary>
        PeoplePropertyType = 24
        ''' <summary>تنظيمات شارژ</summary>
        ChargeSetting = 25
        ''' <summary>تنظيمات رک</summary>
        RackSetting = 25
        ''' <summary>تنظيمات رستوران</summary>
        RestaurantSetting = 25
        ''' <summary>تنظيمات تريا</summary>
        TeriaSetting = 25
        ''' <summary>تنظيمات رجيستر کارت</summary>
        RegisterSetting = 29
        ''' <summary>تنظيمات مشترکين</summary>
        SubscribSetting = 30
        ''' <summary>ساير تنظيمات</summary>
        OtherSetting = 32
        ''' <summary>تنظيمات صورتحساب</summary>
        GustBillSetting = 33
        ''' <summary>تنضيمات رزرو</summary>
        ReserveSetting = 34
        ''' <summary>تنظيمات پيامک</summary>
        SmsSetting = 3
        ''' <summary>تنظيمات کد حساب سند حسابداري</summary>
        AccountCodeSetting = 37
        ''' <summary>تنظيمات لاندري</summary>
        LandrySetting = 38
        ''' <summary>تنظيمات ايميل</summary>
        EmailSetting = 39
        ''' <summary>تنظيمات فروشگاه</summary>
        ShopSetting = 40
        ''' <summary>تنظيمات خانه داري</summary>
        RoomKeepingSetting = 42
        ''' <summary>تنظيمات رزرو خدمات</summary>
        ServiceReserveSetting = 42
        ''' <summary>اعلام چک اوت</summary>
        AnnounceCheckOut = 43
        ''' <summary>انواع مشخصه هاي اتاق</summary>
        RoomPropertyType = 45
        ''' <summary>مراکز هزينه مشخص</summary>
        CostCenterItems = 46
        ''' <summary>انواع مشخصه هاي سرويسها</summary>
        ServicePropertyType = 47
        ''' <summary>123</summary>
        Empty1 = 48
        ''' <summary>انواع مراکز هزينه</summary>
        CostCenterType = 49
        ''' <summary>مرجع ثبت رکورد</summary>
        RowReferenceType = 50
        ''' <summary>نوع ارائه هزينه</summary>
        CostOfferType = 51
        ''' <summary>نوع رديف جزء هزينه ها</summary>
        CashItemRowType = 52
        ''' <summary>انواع رديفهاي قيمت رجيسترکارت</summary>
        RegisterCostTypes = 53
        ''' <summary>ماهيت حسابها</summary>
        AccountNature = 54
        ''' <summary>روش هاي تشخيص حساب مقابل و کد مالي عوامل هزينه</summary>
        CostCenterRecognition = 55
        ''' <summary>انواع مشخصه هاي مراکز هزينه</summary>
        CostCenterPropertyType = 56
        ''' <summary>وضعيت درآمد</summary>
        IncomeStatus = 57
        ''' <summary>وضعيت سند</summary>
        VoucherStatus = 58
        ''' <summary>انواع سند</summary>
        VoucherTypes = 59
        ''' <summary>وضعيت صندوق</summary>
        CashStatus = 60
        ''' <summary>روشهاي تسويه حساب رجيسترکارت</summary>
        RegisterPayoffType = 61
        ''' <summary>انواع مشخصه هاي جدول صندوق</summary>
        CashPropertyType = 62
        ''' <summary>وضعيت رزرو</summary>
        ReserveStatus = 63
        ''' <summary>انواع صورتحسابها</summary>
        BillType = 64
        ''' <summary>انواع فهرست بها</summary>
        PriceListType = 65
        ''' <summary>انواع قيمتهاي فهرست بها</summary>
        PriceListCostType = 66
        ''' <summary>انواع عملگرها</summary>
        Operators = 67
        ''' <summary>مشخصه هاي کاربر</summary>
        UserProperties = 68
        ''' <summary>نوع ترانسفر</summary>
        TransferType = 1
        ''' <summary>وضعيت ترانسفر</summary>
        TransferStatus = 1
        ''' <summary>انواع مجوزها</summary>
        PermissionType = 1
        ''' <summary>انواع مشخصه مجوزها</summary>
        PermissionPropertyType = 1
        ''' <summary>انواع اشياء سيستم</summary>
        SystemObjectType = 1
        ''' <summary>انواع آيکون</summary>
        ImageType = 1
        ''' <summary>منبع اطلاعاتي تلفن</summary>
        TelephoneSorceBase = 1
        ''' <summary>نوع تاريخ</summary>
        DateType = 1
        ''' <summary>نوع ستون فايل متني</summary>
        TextFileColumnType = 1
        ''' <summary>نوع کنترل تلفن</summary>
        TelephoneControlType = 1
        ''' <summary>انواع فرمت تاريخ</summary>
        DateFormat = 1
        ''' <summary>انواع فرمت ساعت</summary>
        TimeFormat = 1
        ''' <summary>انواع فرمت مدت مکالمه</summary>
        DurationFormat = 1
        ''' <summary>انواع تلفنها</summary>
        TelephoneBookItemType = 1
        ''' <summary>انواع ضمائم</summary>
        AttachmentType = 1
        ''' <summary>انواع شيفت</summary>
        ShiftType = 1
        ''' <summary>وضعيت مشترکين</summary>
        SubscribeStatus = 1
        ''' <summary>انواع PocketPc</summary>
        PocketPcType = 1
        ''' <summary>انواع مشخصه هاي صورتحساب</summary>
        BillPropertyType = 1
        ''' <summary>وضعيت رزروهاي اينترنتي</summary>
        InternetReserveStatus = 1
        ''' <summary>نوع واحد پرينتر</summary>
        PrintUnitType = 1
        ''' <summary>نوع تخفيف</summary>
        DiscountType = 90
        ''' <summary>نوع مقدار دامنه</summary>
        DomainValueType = 91
        ''' <summary>نوع آژانس رزرواسيون</summary>
        AgencyType = 92
        ''' <summary>وضعيت ارسال پيامک</summary>
        SMSSendStatus = 93
        ''' <summary>نوع پيامک</summary>
        SmsRowType = 94
        ''' <summary>نوع محاسبه هزينه ها</summary>
        CostCalculationType = 95
        ''' <summary>انواع منبع ضمائم</summary>
        AttachmentReferenceType = 96
        ''' <summary>انواع تخفيف کارت اشتراک</summary>
        DiscountPropertiesType = 97
        ''' <summary>نوع مهمان</summary>
        GuestAgeTypes = 98
        ''' <summary>نوع تحويل صورتحساب</summary>
        BillDeliveryType = 98
        ''' <summary>نوع کارت شناسايي</summary>
        IdentityCardTypes = 100
        ''' <summary>RegisterTransferانواع رکودهاي جدول</summary>
        RegisterTransferType = 101
        ''' <summary>انواع تغييرات اطلاعات</summary>
        ModifyType = 102
        ''' <summary>وضعيت ميز</summary>
        LocationStatus = 102
        ''' <summary>نوع ايميل</summary>
        EmailRowType = 103
        ''' <summary>انواع گارانتي قرارداد</summary>
        ContractGuaranteeTypes = 105
        ''' <summary>انواع مشخصه قرارداد</summary>
        ContractPropertyType = 1
        ''' <summary>انواع کالا</summary>
        GoodType = 1
        ''' <summary> پايگاه اطلاعات</summary>
        DataBaseType = 1
        ''' <summary>انواع اطلاعات مشخصات هتل</summary>
        HotelConfigurationType = 1
        ''' <summary>درخواستهاي اتاق</summary>
        RoomRequests = 1
        ''' <summary>انواع قيمت گذاري کالا</summary>
        GoodPriceingType = 1
        ''' <summary>انواع قيمت تمام شده </summary>
        CostControlType = 1
        ''' <summary>انواع محلهاي قيمت تمام شده</summary>
        CostControlPlaceType = 1
        ''' <summary>انواع مستندات انبار</summary>
        StoreDocumentType = 1
        ''' <summary>تنظيمات صبحانه</summary>
        BreakfastSetting = 1
        ''' <summary>نوع درخواست کالا</summary>
        GoodRequestType = 1
        ''' <summary>انواع انبار گرداني</summary>
        StoreHandlingTypes = 1
        ''' <summary>نوع انبار</summary>
        StoreTypes = 1
        ''' <summary>نوع تحويل کالا</summary>
        GoodDeliveryType = 119
        ''' <summary>وضعيت درخواست کالا</summary>
        GoodRequestStatus = 120
        ''' <summary>وضعيت کالا</summary>
        GoodStatus = 121
        ''' <summary>نوع sqript</summary>
        SgriptType = 1
        ''' <summary>Delete شود-Recipe انواع</summary>
        TypeOfRecipe = 123
        ''' <summary>انواع مشخصه هاي درخواست کالا</summary>
        GoodRequestPropertyTypes = 124
        ''' <summary>سطوح دستور کار مالي</summary>
        AccountLevels = 125
        ''' <summary>وضعيت غذاهاي باقي مانده</summary>
        StatusRemainFood = 126
        ''' <summary>انواع مشخصه هاي انبار</summary>
        StorePropertyType = 127
        ''' <summary>نوع حسابها</summary>
        TypesOfAccounts = 128
        ''' <summary>انواع چک</summary>
        TypesOfCheques = 129
        ''' <summary>عمليات چک</summary>
        OperationsOfCheques = 130
        ''' <summary>وضعيت چک</summary>
        StatusOfCheques = 131
        ''' <summary>تنظيمات پيام صوتي</summary>
        AudioMessageSetting = 45
        ''' <summary>تنظيمات انبار و کاست کنترل</summary>
        StoreAndCostControlSetting = 46
        ''' <summary>نوع گروه حساب</summary>
        AccountingGroupType = 134
        ''' <summary>انواع پيام صوتي</summary>
        AudioMessageType = 133
        ''' <summary>تنظيمات PC POS</summary>
        PcPosSetting = 47
        ''' <summary>مراکز کنترل هزينه</summary>
        CostControlCenters = 137
        ''' <summary>نوع سند چک</summary>
        TypeOfDocCheque = 138
        ''' <summary>انواع محتواي کارتابل</summary>
        ContentType = 1
        ''' <summary>نوع اقدام کارتابل</summary>
        PerformType = 1
        ''' <summary>علت وضعيت چک</summary>
        ReasonOfChequesStatus = 141
        ''' <summary>انواع ضمائم رديف سند</summary>
        TypeOfContentsDocument = 142
        ''' <summary>سطوح دسترسي</summary>
        AppendType = 17
        ''' <summary>انواع دوره هاي خدمات رزرو</summary>
        ServiceCyclesType = 144
        ''' <summary>نوع فرمول</summary>
        SalaryFormulaType = 145
        ''' <summary>نوع گروه فرمولها</summary>
        SalaryFormulaGroup = 146
        ''' <summary>نوع محاسبات فرمولهاي حقوق</summary>
        SalaryFormulaCalculationType = 147
        ''' <summary>وضعيت رزرو غذا</summary>
        FoodReserveStatus = 132
        ''' <summary>نوع پرداختي</summary>
        SalaryType = 149
        ''' <summary>نوع مقادير</summary>
        ValueType = 150
        ''' <summary>نوع کنترل</summary>
        ControlType = 151
        ''' <summary>انواع نامه ها</summary>
        LetterType = 152
        ''' <summary>نوع مشخصه چک</summary>
        ChequesPropertyType = 153
        ''' <summary>انواع صدور درخواست</summary>
        RequestType = 154
        ''' <summary>وضعيت درخواست</summary>
        RequestStatus = 155
        ''' <summary>انواع فاکتور انبار</summary>
        TypeOfFactors = 156
        ''' <summary>تنظيمات اسپا سنتر</summary>
        SpaSetting = 2
        ''' <summary>انواع صورتحساب ها</summary>
        BillSubType = 158
        ''' <summary>درگاه هاي پرداخت اينترنتي</summary>
        InternetPaymentPorts = 1
        ''' <summary>سيستم هاي درخواست کننده PcPos</summary>
        PcPosApplicantSystems = 1
        ''' <summary>نوع مرتب سازي</summary>
        TypeOfSort = 161
        ''' <summary>وضعيت پرداخت PCPOS</summary>
        PcPosPaymentStatus = 1
        ''' <summary>انواع گروه بندي کالا</summary>
        TypeOfGoods = 163
        ''' <summary>نحوه پرداخت جديد</summary>
        NewPayType = 164
        ''' <summary>انواع صورت هاي مالي</summary>
        FinancialStatementsTypes = 165
        ''' <summary>انواع ماهيت صورت هاي مالي</summary>
        FinancialStatementsNature = 166
        ''' <summary>انواع مشخصه هاي سرشکن حساب ها</summary>
        VariousTypesProrateAccount = 1
        ''' <summary>نحوه ي محاسبه سرشکن حسابها</summary>
        CalculateAccounts = 1
        ''' <summary>انواع وضعيت برگه هاي انبار</summary>
        TypeOfStatusStoreDocument = 169
        ''' <summary>وضعيت نامه</summary>
        LetterStatus = 170
        ''' <summary>سوابق پرسنل</summary>
        PeopleHistory = 171
        ''' <summary>مقاطع تحصيلي</summary>
        StudyLevel = 172
        ''' <summary>درجه نياز</summary>
        NecessaryDegree = 173
        ''' <summary>نوع قرارداد رزرو خدمات</summary>
        ContractTypeReserve = 174
        ''' <summary>نوع فرمول حکم</summary>
        PrescriptionFormulaType = 175
        ''' <summary>گروه بندي اطلاعات حکم</summary>
        PrescriptionFormulaGroups = 176
        ''' <summary>سيستم</summary>
        SubSystem = 177
        ''' <summary>کيفيت آموزشي</summary>
        EducationQuality = 178
        ''' <summary>نوع پرسنل</summary>
        PERSONNEL_TYPE = 179
        ''' <summary>زبان اصلي</summary>
        MainLaguage = 180
        ''' <summary>بخش شغلي</summary>
        Job_Section = 181
        ''' <summary>درجه تسلط</summary>
        GripeDegree = 182
        ''' <summary>نوع عملکرد مشترکين</summary>
        Subscribe_Operation_Type = 183
        ''' <summary>نوع استخدام پرسنل</summary>
        PeopleEmploymentType = 184
        ''' <summary>وضعيت تاهل</summary>
        MaritalStatus = 185
        ''' <summary>نوع ورود اطلاعات کدينگ</summary>
        AccountItemType = 185
        ''' <summary>پارامترهاي متغير سيستمي احکام</summary>
        PrescriptionParameterSystem = 187
        ''' <summary>جداول سيستمي مالي</summary>
        AccountTableSystems = 188
        ''' <summary>انواع آيتم هاي خزانه داري</summary>
        BursaryType = 189
        ''' <summary>انواع کدينگهاي بانک</summary>
        BankAccountCode = 190
        ''' <summary>انواع مشخصه هاي کالا</summary>
        GoodProperties = 191
        ''' <summary>انواع استهلاک گيري</summary>
        PossessionWearOffType = 191
        ''' <summary>انواع اموال</summary>
        PossessionType = 193
        ''' <summary>انواع وضعيت اموال</summary>
        PossessionStatus = 194
        ''' <summary>انواع دليل استهلاک اموال</summary>
        PossessionWearOffReason = 195
        ''' <summary>انواع وابستگي فهرست بها</summary>
        PriceListDependencyType = 196
        ''' <summary>موجودي اول دوره خزانه داري</summary>
        AccountInitialBalanceType = 197
        ''' <summary>نوع قيمت گذاري اسناد انبار</summary>
        StoreDocumentPriceingTypes = 192
        ''' <summary>انواع پاسخ</summary>
        ResponseType = 1
        ''' <summary>نوع پاسخ Selectي</summary>
        SelectiveResponseType = 1
        ''' <summary>پاسخ نظرسنجي</summary>
        ResponseVote = 1
        ''' <summary>دسته بندي</summary>
        QuestionGroups = 1
        ''' <summary>نوع فرم</summary>
        FormType = 1
        ''' <summary>مخاطب</summary>
        Audiance = 1
        ''' <summary>انواع نحوه صدور سند</summary>
        TypesOfDocumentIssuance = 205
        ''' <summary>انواع اطلاعات در شرح سند انبار</summary>
        FieldsOfStoreVoucher = 205
        ''' <summary>انواع شرح اسناد انبار</summary>
        StoreVoucherTemplates = 207
        ''' <summary>نوع داده پاسخ تشريحي</summary>
        ResponseDescType = 1
        ''' <summary>انواع نگهداري تجهيز</summary>
        MaintenanceTypes = 191
        ''' <summary>انواع دوره نگهداري</summary>
        DurationTypes = 192
        ''' <summary>نوع ثبت رسيد</summary>
        ReceiptType = 193
        ''' <summary>انواع فصل</summary>
        SeasonType = 212
        ''' <summary>انواع مشخصه هاي اتاق هاي رجيستر شده</summary>
        RegisterRoomProperty = 627
        ''' <summary>وضعيت درخواست</summary>
        ServiceRequestStatus = 1
        ''' <summary>تنظيمات اندازه رک</summary>
        RackSizeSetting = 1
        ''' <summary>انواع Recipe </summary>
        RecipiTypes = 1
        ''' <summary>انواع وضعيت Exit کالا و اموال</summary>
        GoodExitStatus = 635
        ''' <summary>غذا و نوشابه</summary>
        CostFood = 1
        ''' <summary>واحدهاي اقامتي</summary>
        CostRooms = 2
        ''' <summary>لاندري</summary>
        CostLandry = 3
        ''' <summary>تريا</summary>
        CostTeria = 4
        ''' <summary>گرانترين نرخ</summary>
        Maximum = 1
        ''' <summary>ارزانترين نرخ</summary>
        Minimum = 2
        ''' <summary>ميانگين نرخ</summary>
        Average = 3
        ''' <summary>همان شب</summary>
        SameNight = 4
    End Enum

    Public Enum DomainKeys
        ''' <summary>انواع وضعيت اتاقها</summary>
        RoomStatus = 1
        ''' <summary>انواع قيمتهاي انواع اتاق</summary>
        RoomPriceType = 2
        ''' <summary>مبناي محاسبه قيمتها در شارژ</summary>
        CostBasedType = 3
        ''' <summary>مرجع قيمتها در شارژ</summary>
        CostReferenceType = 4
        ''' <summary>نوع شارژ</summary>
        ChargeType = 5
        ''' <summary>نوع محدوديت در شارژ</summary>
        ChargeLimitType = 6
        ''' <summary>بازه کنترل محدوديت</summary>
        ChargeLimitDuration = 7
        ''' <summary>انواع شهرها</summary>
        CityType = 8
        ''' <summary>جنسيت</summary>
        Gender = 9
        ''' <summary>انواع مردم</summary>
        PeopleType = 10
        ''' <summary>انواع دسته بن</summary>
        BillSerialType = 11
        ''' <summary>وضعيتهاي رجيسترکارت</summary>
        RegisterStatus = 12
        ''' <summary>وضعيتهاي اتاقهاي رجيسترکارت</summary>
        RegisterRoomStatus = 13
        ''' <summary>وضعيتهاي اتاق مهمانان رجيسترکارت</summary>
        RegisterRoomGuestStatus = 14
        ''' <summary>وضعيتهاي مهمانان رجيسترکارت</summary>
        RegisterGuestStatus = 15
        ''' <summary>وضعيتها</summary>
        Status = 16
        ''' <summary>انواع مهمانان رجيستر</summary>
        RegisterGuestType = 17
        ''' <summary>انواع شرکتها</summary>
        ContractorType = 18
        ''' <summary>نحوه پرداخت</summary>
        PayType = 19
        ''' <summary>نوع سرويس رستوران</summary>
        FoodServiceType = 20
        ''' <summary>وضعيت صورتحسابها</summary>
        BillStatus = 21
        ''' <summary>انواع سرويس ها</summary>
        ServiceType = 22
        ''' <summary>انواع خصوصيات رجيستر</summary>
        RegisterPropertyType = 23
        ''' <summary>انواع خصوصيات افراد</summary>
        PeoplePropertyType = 24
        ''' <summary>تنظيمات شارژ</summary>
        ChargeSetting = 26
        ''' <summary>تنظيمات رک</summary>
        RackSetting = 27
        ''' <summary>تنظيمات رستوران</summary>
        RestaurantSetting = 28
        ''' <summary>تنظيمات تريا</summary>
        TeriaSetting = 29
        ''' <summary>تنظيمات رجيستر کارت</summary>
        RegisterSetting = 30
        ''' <summary>تنظيمات مشترکين</summary>
        SubscribSetting = 31
        ''' <summary>ساير تنظيمات</summary>
        OtherSetting = 32
        ''' <summary>تنظيمات صورتحساب</summary>
        GustBillSetting = 33
        ''' <summary>تنضيمات رزرو</summary>
        ReserveSetting = 34
        ''' <summary>تنظيمات پيامک</summary>
        SmsSetting = 35
        ''' <summary>تنظيمات کد حساب سند حسابداري</summary>
        AccountCodeSetting = 37
        ''' <summary>تنظيمات لاندري</summary>
        LandrySetting = 38
        ''' <summary>تنظيمات ايميل</summary>
        EmailSetting = 39
        ''' <summary>تنظيمات فروشگاه</summary>
        ShopSetting = 40
        ''' <summary>تنظيمات خانه داري</summary>
        RoomKeepingSetting = 41
        ''' <summary>تنظيمات رزرو خدمات</summary>
        ServiceReserveSetting = 42
        ''' <summary>اعلام چک اوت</summary>
        AnnounceCheckOut = 43
        ''' <summary>انواع مشخصه هاي اتاق</summary>
        RoomPropertyType = 45
        ''' <summary>مراکز هزينه مشخص</summary>
        CostCenterItems = 46
        ''' <summary>انواع مشخصه هاي سرويسها</summary>
        ServicePropertyType = 47
        ''' <summary>123</summary>
        Empty1 = 48
        ''' <summary>انواع مراکز هزينه</summary>
        CostCenterType = 49
        ''' <summary>مرجع ثبت رکورد</summary>
        RowReferenceType = 50
        ''' <summary>نوع ارائه هزينه</summary>
        CostOfferType = 51
        ''' <summary>نوع رديف جزء هزينه ها</summary>
        CashItemRowType = 52
        ''' <summary>انواع رديفهاي قيمت رجيسترکارت</summary>
        RegisterCostTypes = 53
        ''' <summary>ماهيت حسابها</summary>
        AccountNature = 54
        ''' <summary>روش هاي تشخيص حساب مقابل و کد مالي عوامل هزينه</summary>
        CostCenterRecognition = 55
        ''' <summary>انواع مشخصه هاي مراکز هزينه</summary>
        CostCenterPropertyType = 56
        ''' <summary>وضعيت درآمد</summary>
        IncomeStatus = 57
        ''' <summary>وضعيت سند</summary>
        VoucherStatus = 58
        ''' <summary>انواع سند</summary>
        VoucherTypes = 59
        ''' <summary>وضعيت صندوق</summary>
        CashStatus = 60
        ''' <summary>روشهاي تسويه حساب رجيسترکارت</summary>
        RegisterPayoffType = 61
        ''' <summary>انواع مشخصه هاي جدول صندوق</summary>
        CashPropertyType = 62
        ''' <summary>وضعيت رزرو</summary>
        ReserveStatus = 63
        ''' <summary>انواع صورتحسابها</summary>
        BillType = 64
        ''' <summary>انواع فهرست بها</summary>
        PriceListType = 65
        ''' <summary>انواع قيمتهاي فهرست بها</summary>
        PriceListCostType = 66
        ''' <summary>انواع عملگرها</summary>
        Operators = 67
        ''' <summary>مشخصه هاي کاربر</summary>
        UserProperties = 68
        ''' <summary>نوع ترانسفر</summary>
        TransferType = 69
        ''' <summary>وضعيت ترانسفر</summary>
        TransferStatus = 70
        ''' <summary>انواع مجوزها</summary>
        PermissionType = 71
        ''' <summary>انواع مشخصه مجوزها</summary>
        PermissionPropertyType = 72
        ''' <summary>انواع اشياء سيستم</summary>
        SystemObjectType = 73
        ''' <summary>انواع آيکون</summary>
        ImageType = 74
        ''' <summary>منبع اطلاعاتي تلفن</summary>
        TelephoneSorceBase = 75
        ''' <summary>نوع تاريخ</summary>
        DateType = 76
        ''' <summary>نوع ستون فايل متني</summary>
        TextFileColumnType = 77
        ''' <summary>نوع کنترل تلفن</summary>
        TelephoneControlType = 78
        ''' <summary>انواع فرمت تاريخ</summary>
        DateFormat = 79
        ''' <summary>انواع فرمت ساعت</summary>
        TimeFormat = 80
        ''' <summary>انواع فرمت مدت مکالمه</summary>
        DurationFormat = 81
        ''' <summary>انواع تلفنها</summary>
        TelephoneBookItemType = 82
        ''' <summary>انواع ضمائم</summary>
        AttachmentType = 83
        ''' <summary>انواع شيفت</summary>
        ShiftType = 84
        ''' <summary>وضعيت مشترکين</summary>
        SubscribeStatus = 85
        ''' <summary>انواع PocketPc</summary>
        PocketPcType = 86
        ''' <summary>انواع مشخصه هاي صورتحساب</summary>
        BillPropertyType = 87
        ''' <summary>وضعيت رزروهاي اينترنتي</summary>
        InternetReserveStatus = 88
        ''' <summary>نوع واحد پرينتر</summary>
        PrintUnitType = 89
        ''' <summary>نوع تخفيف</summary>
        DiscountType = 90
        ''' <summary>نوع مقدار دامنه</summary>
        DomainValueType = 91
        ''' <summary>نوع آژانس رزرواسيون</summary>
        AgencyType = 92
        ''' <summary>وضعيت ارسال پيامک</summary>
        SMSSendStatus = 93
        ''' <summary>نوع پيامک</summary>
        SmsRowType = 94
        ''' <summary>نوع محاسبه هزينه ها</summary>
        CostCalculationType = 95
        ''' <summary>انواع منبع ضمائم</summary>
        AttachmentReferenceType = 96
        ''' <summary>انواع تخفيف کارت اشتراک</summary>
        DiscountPropertiesType = 97
        ''' <summary>نوع مهمان</summary>
        GuestAgeTypes = 98
        ''' <summary>نوع تحويل صورتحساب</summary>
        BillDeliveryType = 99
        ''' <summary>نوع کارت شناسايي</summary>
        IdentityCardTypes = 100
        ''' <summary>RegisterTransferانواع رکودهاي جدول</summary>
        RegisterTransferType = 101
        ''' <summary>انواع تغييرات اطلاعات</summary>
        ModifyType = 102
        ''' <summary>وضعيت ميز</summary>
        LocationStatus = 103
        ''' <summary>نوع ايميل</summary>
        EmailRowType = 104
        ''' <summary>انواع گارانتي قرارداد</summary>
        ContractGuaranteeTypes = 105
        ''' <summary>انواع مشخصه قرارداد</summary>
        ContractPropertyType = 106
        ''' <summary>انواع کالا</summary>
        GoodType = 107
        ''' <summary> پايگاه اطلاعات</summary>
        DataBaseType = 108
        ''' <summary>انواع اطلاعات مشخصات هتل</summary>
        HotelConfigurationType = 109
        ''' <summary>درخواستهاي اتاق</summary>
        RoomRequests = 110
        ''' <summary>انواع قيمت گذاري کالا</summary>
        GoodPriceingType = 111
        ''' <summary>انواع قيمت تمام شده </summary>
        CostControlType = 112
        ''' <summary>انواع محلهاي قيمت تمام شده</summary>
        CostControlPlaceType = 113
        ''' <summary>انواع مستندات انبار</summary>
        StoreDocumentType = 114
        ''' <summary>تنظيمات صبحانه</summary>
        BreakfastSetting = 115
        ''' <summary>نوع درخواست کالا</summary>
        GoodRequestType = 116
        ''' <summary>انواع انبار گرداني</summary>
        StoreHandlingTypes = 117
        ''' <summary>نوع انبار</summary>
        StoreTypes = 118
        ''' <summary>نوع تحويل کالا</summary>
        GoodDeliveryType = 119
        ''' <summary>وضعيت درخواست کالا</summary>
        GoodRequestStatus = 120
        ''' <summary>وضعيت کالا</summary>
        GoodStatus = 121
        ''' <summary>نوع sqript</summary>
        SgriptType = 122
        ''' <summary>Delete شود-Recipe انواع</summary>
        TypeOfRecipe = 123
        ''' <summary>انواع مشخصه هاي درخواست کالا</summary>
        GoodRequestPropertyTypes = 124
        ''' <summary>سطوح دستور کار مالي</summary>
        AccountLevels = 125
        ''' <summary>وضعيت غذاهاي باقي مانده</summary>
        StatusRemainFood = 126
        ''' <summary>انواع مشخصه هاي انبار</summary>
        StorePropertyType = 127
        ''' <summary>نوع حسابها</summary>
        TypesOfAccounts = 128
        ''' <summary>انواع چک</summary>
        TypesOfCheques = 129
        ''' <summary>عمليات چک</summary>
        OperationsOfCheques = 130
        ''' <summary>وضعيت چک</summary>
        StatusOfCheques = 131
        ''' <summary>تنظيمات پيام صوتي</summary>
        AudioMessageSetting = 132
        ''' <summary>تنظيمات انبار و کاست کنترل</summary>
        StoreAndCostControlSetting = 133
        ''' <summary>نوع گروه حساب</summary>
        AccountingGroupType = 134
        ''' <summary>انواع پيام صوتي</summary>
        AudioMessageType = 135
        ''' <summary>تنظيمات PC POS</summary>
        PcPosSetting = 136
        ''' <summary>مراکز کنترل هزينه</summary>
        CostControlCenters = 137
        ''' <summary>نوع سند چک</summary>
        TypeOfDocCheque = 138
        ''' <summary>انواع محتواي کارتابل</summary>
        ContentType = 139
        ''' <summary>نوع اقدام کارتابل</summary>
        PerformType = 140
        ''' <summary>علت وضعيت چک</summary>
        ReasonOfChequesStatus = 141
        ''' <summary>انواع ضمائم رديف سند</summary>
        TypeOfContentsDocument = 142
        ''' <summary>سطوح دسترسي</summary>
        AppendType = 143
        ''' <summary>انواع دوره هاي خدمات رزرو</summary>
        ServiceCyclesType = 144
        ''' <summary>نوع فرمول</summary>
        SalaryFormulaType = 145
        ''' <summary>نوع گروه فرمولها</summary>
        SalaryFormulaGroup = 146
        ''' <summary>نوع محاسبات فرمولهاي حقوق</summary>
        SalaryFormulaCalculationType = 147
        ''' <summary>وضعيت رزرو غذا</summary>
        FoodReserveStatus = 148
        ''' <summary>نوع پرداختي</summary>
        SalaryType = 149
        ''' <summary>نوع مقادير</summary>
        ValueType = 150
        ''' <summary>نوع کنترل</summary>
        ControlType = 151
        ''' <summary>انواع نامه ها</summary>
        LetterType = 152
        ''' <summary>نوع مشخصه چک</summary>
        ChequesPropertyType = 153
        ''' <summary>انواع صدور درخواست</summary>
        RequestType = 154
        ''' <summary>وضعيت درخواست</summary>
        RequestStatus = 155
        ''' <summary>انواع فاکتور انبار</summary>
        TypeOfFactors = 156
        ''' <summary>تنظيمات اسپا سنتر</summary>
        SpaSetting = 157
        ''' <summary>انواع صورتحساب ها</summary>
        BillSubType = 158
        ''' <summary>درگاه هاي پرداخت اينترنتي</summary>
        InternetPaymentPorts = 159
        ''' <summary>سيستم هاي درخواست کننده PcPos</summary>
        PcPosApplicantSystems = 160
        ''' <summary>نوع مرتب سازي</summary>
        TypeOfSort = 161
        ''' <summary>وضعيت پرداخت PCPOS</summary>
        PcPosPaymentStatus = 162
        ''' <summary>انواع گروه بندي کالا</summary>
        TypeOfGoods = 163
        ''' <summary>نحوه پرداخت جديد</summary>
        NewPayType = 164
        ''' <summary>انواع صورت هاي مالي</summary>
        FinancialStatementsTypes = 165
        ''' <summary>انواع ماهيت صورت هاي مالي</summary>
        FinancialStatementsNature = 166
        ''' <summary>انواع مشخصه هاي سرشکن حساب ها</summary>
        VariousTypesProrateAccount = 167
        ''' <summary>نحوه ي محاسبه سرشکن حسابها</summary>
        CalculateAccounts = 168
        ''' <summary>انواع وضعيت برگه هاي انبار</summary>
        TypeOfStatusStoreDocument = 169
        ''' <summary>وضعيت نامه</summary>
        LetterStatus = 170
        ''' <summary>سوابق پرسنل</summary>
        PeopleHistory = 171
        ''' <summary>مقاطع تحصيلي</summary>
        StudyLevel = 172
        ''' <summary>درجه نياز</summary>
        NecessaryDegree = 173
        ''' <summary>نوع قرارداد رزرو خدمات</summary>
        ContractTypeReserve = 174
        ''' <summary>نوع فرمول حکم</summary>
        PrescriptionFormulaType = 175
        ''' <summary>گروه بندي اطلاعات حکم</summary>
        PrescriptionFormulaGroups = 176
        ''' <summary>سيستم</summary>
        SubSystem = 177
        ''' <summary>کيفيت آموزشي</summary>
        EducationQuality = 178
        ''' <summary>نوع پرسنل</summary>
        PERSONNEL_TYPE = 179
        ''' <summary>زبان اصلي</summary>
        MainLaguage = 180
        ''' <summary>بخش شغلي</summary>
        Job_Section = 181
        ''' <summary>درجه تسلط</summary>
        GripeDegree = 182
        ''' <summary>نوع عملکرد مشترکين</summary>
        Subscribe_Operation_Type = 183
        ''' <summary>نوع استخدام پرسنل</summary>
        PeopleEmploymentType = 184
        ''' <summary>وضعيت تاهل</summary>
        MaritalStatus = 185
        ''' <summary>نوع ورود اطلاعات کدينگ</summary>
        AccountItemType = 186
        ''' <summary>پارامترهاي متغير سيستمي احکام</summary>
        PrescriptionParameterSystem = 187
        ''' <summary>جداول سيستمي مالي</summary>
        AccountTableSystems = 188
        ''' <summary>انواع آيتم هاي خزانه داري</summary>
        BursaryType = 189
        ''' <summary>انواع کدينگهاي بانک</summary>
        BankAccountCode = 190
        ''' <summary>انواع مشخصه هاي کالا</summary>
        GoodProperties = 191
        ''' <summary>انواع استهلاک گيري</summary>
        PossessionWearOffType = 192
        ''' <summary>انواع اموال</summary>
        PossessionType = 193
        ''' <summary>انواع وضعيت اموال</summary>
        PossessionStatus = 194
        ''' <summary>انواع دليل استهلاک اموال</summary>
        PossessionWearOffReason = 195
        ''' <summary>انواع وابستگي فهرست بها</summary>
        PriceListDependencyType = 196
        ''' <summary>موجودي اول دوره خزانه داري</summary>
        AccountInitialBalanceType = 197
        ''' <summary>نوع قيمت گذاري اسناد انبار</summary>
        StoreDocumentPriceingTypes = 198
        ''' <summary>انواع پاسخ</summary>
        ResponseType = 199
        ''' <summary>نوع پاسخ Selectي</summary>
        SelectiveResponseType = 200
        ''' <summary>پاسخ نظرسنجي</summary>
        ResponseVote = 201
        ''' <summary>دسته بندي</summary>
        QuestionGroups = 202
        ''' <summary>نوع فرم</summary>
        FormType = 203
        ''' <summary>مخاطب</summary>
        Audiance = 204
        ''' <summary>انواع نحوه صدور سند</summary>
        TypesOfDocumentIssuance = 205
        ''' <summary>انواع اطلاعات در شرح سند انبار</summary>
        FieldsOfStoreVoucher = 206
        ''' <summary>انواع شرح اسناد انبار</summary>
        StoreVoucherTemplates = 207
        ''' <summary>نوع داده پاسخ تشريحي</summary>
        ResponseDescType = 208
        ''' <summary>انواع نگهداري تجهيز</summary>
        MaintenanceTypes = 209
        ''' <summary>انواع دوره نگهداري</summary>
        DurationTypes = 210
        ''' <summary>نوع ثبت رسيد</summary>
        ReceiptType = 211
        ''' <summary>انواع فصل</summary>
        SeasonType = 212
        ''' <summary>انواع مشخصه هاي اتاق هاي رجيستر شده</summary>
        RegisterRoomProperty = 213
        ''' <summary>وضعيت درخواست</summary>
        ServiceRequestStatus = 214
        ''' <summary>تنظيمات اندازه رک</summary>
        RackSizeSetting = 520
        ''' <summary>انواع Recipe </summary>
        RecipiTypes = 544
        ''' <summary>انواع وضعيت Exit کالا و اموال</summary>
        GoodExitStatus = 635
        ''' <summary>غذا و نوشابه</summary>
        CostFood = 2841
        ''' <summary>واحدهاي اقامتي</summary>
        CostRooms = 2842
        ''' <summary>لاندري</summary>
        CostLandry = 2843
        ''' <summary>تريا</summary>
        CostTeria = 2844
        ''' <summary>گرانترين نرخ</summary>
        Maximum = 4540
        ''' <summary>ارزانترين نرخ</summary>
        Minimum = 4541
        ''' <summary>ميانگين نرخ</summary>
        Average = 4542
        ''' <summary>همان شب</summary>
        SameNight = 4543
    End Enum

    Public Enum PropertyKeys
        ''' <summary>تيپهاي ميني بار</summary>
        MinibarType = 501
        ''' <summary>شغلها</summary>
        Job = 502
        ''' <summary>مرزهاي کشور</summary>
        CountryBorder = 503
        ''' <summary>نسبت مهمانان</summary>
        GuestRelationShip = 504
        ''' <summary>وسيله سفر</summary>
        TravelVehicle = 505
        ''' <summary>دلايل سفر</summary>
        TravelCause = 506
        ''' <summary>رستوران ها</summary>
        Restaurant = 507
        ''' <summary>ميزهاي رستوران</summary>
        RestaurantTables = 508
        ''' <summary>واحد ها</summary>
        Units = 509
        ''' <summary>امکانات اتاق</summary>
        RoomFacilities = 510
        ''' <summary>آشپزخانه</summary>
        Kitchen = 511
        ''' <summary>واحدهاي رزرو کننده</summary>
        ReserverUnit = 512
        ''' <summary>بانکها</summary>
        Bank = 513
        ''' <summary>گروه هاي عملکرد حسابها</summary>
        AccountOperationGroupItems = 515
        ''' <summary>کافي شاپها</summary>
        Teria = 516
        ''' <summary>واحد دسر</summary>
        DesertUnit = 517
        ''' <summary>انواع مشترکين</summary>
        SubscribeType = 518
        ''' <summary>شماره کارتهاي پارکينگ</summary>
        ParkingCardNo = 519
        ''' <summary>انواع رنگ</summary>
        Colors = 521
        ''' <summary>انواع خودرو</summary>
        CarTypes = 522
        ''' <summary>PocketPc</summary>
        PocketPc = 523
        ''' <summary>سوالات نظرسنجي</summary>
        VoteQuestion = 524
        ''' <summary>گروه سوالات نظرسنجي</summary>
        VoteQuestionGroup = 525
        ''' <summary>نتايج نظرسنجي</summary>
        VoteResult = 526
        ''' <summary>گروههاي دفترچه تلفن</summary>
        TelepnoneBookCategory = 527
        ''' <summary>دلايل ورود و Exit کالا</summary>
        GoodRequestReason = 528
        ''' <summary>واحدهاي سازماني</summary>
        OrganizationUnit = 529
        ''' <summary>انواع تشريفات</summary>
        TransferType = 530
        ''' <summary>انواع امکانات</summary>
        HotelFacilities = 531
        ''' <summary>انواع VIP</summary>
        VipTypes = 532
        ''' <summary>انواع لاندري</summary>
        LandryTypes = 533
        ''' <summary>انواع طريقه آشنايي با هتل</summary>
        HowAboutTheHotel = 534
        ''' <summary>فروشگاه</summary>
        Shop = 535
        ''' <summary>آيتمهاي گزارش رک</summary>
        RackReportItems = 536
        ''' <summary>گروهاي غذايي رستوران</summary>
        ResturantFoodGroups = 537
        ''' <summary>گروهاي غذايي تريا</summary>
        TeriaFoodGroups = 538
        ''' <summary>سالن ها</summary>
        Salons = 539
        ''' <summary>ديتابيس ها</summary>
        DataBases = 540
        ''' <summary>انواع محلهاي ارائه خدمات</summary>
        LocationTypes = 541
        ''' <summary>خواص غذاها</summary>
        FoodFeature = 542
        ''' <summary>انواع انبارهاي کالا</summary>
        GoodStoreTypes = 543
        ''' <summary>انواع ترانسفر</summary>
        TransferVehicleType = 545
        ''' <summary>محلهاي گشت</summary>
        TourPlace = 546
        ''' <summary>انواع Recipi اتاق</summary>
        RoomRecipiTypes = 547
        ''' <summary>انواع ملزومات اتاق</summary>
        RoomSuppliesTypes = 548
        ''' <summary>محل مصرف کالا</summary>
        ConsumePlace = 549
        ''' <summary>موضوع سند</summary>
        VoucherSubject = 550
        ''' <summary>شرح رديف سند</summary>
        VoucherDescriptionRow = 551
        ''' <summary>واحد مالي</summary>
        AccountingUnit = 552
        ''' <summary>ليست منو غذايي</summary>
        FoodListMenu = 553
        ''' <summary>علت رزرو</summary>
        ReserveReason = 554
        ''' <summary>انواع ارز</summary>
        CurrencyType = 555
        ''' <summary>تالارها</summary>
        Talar = 556
        ''' <summary>هتل</summary>
        HOTEL = 557
        ''' <summary>نظام هاي پرداختي</summary>
        SalaryPaymentType = 565
        ''' <summary>نوع بن</summary>
        BillSubType = 566
        ''' <summary>انواع اسپا</summary>
        SpaCenters = 567
        ''' <summary>کدهاي خطاي وب سرويس اماکن</summary>
        ErrorCodeOfWebServiceAmaken = 568
        ''' <summary>رشته هاي تحصيلي</summary>
        StudyBranch = 569
        ''' <summary>نوع انقطاع خدمت</summary>
        DisEmployeeReason = 570
        ''' <summary>نظام هاي حکمي</summary>
        PrescriptionWorkBook = 571
        ''' <summary>امضاء کنندگان احکام</summary>
        SignaturePrescription = 572
        ''' <summary>نوع حکم</summary>
        IssuePrescriptionType = 573
        ''' <summary>شرح حکم</summary>
        DescriptionPrescriptionType = 574
        ''' <summary>انواع اديان</summary>
        ReligiontYPE = 575
        ''' <summary>انواع مقاطع تحصيلي</summary>
        StudySection = 576
        ''' <summary>انواع مدارک تحصيلي</summary>
        StudyVoucher = 577
        ''' <summary>انواع ارگان هاي نظام وظيفه</summary>
        MiliarityOrganType = 578
        ''' <summary>انواع رسته هاي نظام وظيفه</summary>
        MiliarityClassType = 580
        ''' <summary>انواع درجات نظام وظيفه</summary>
        MiliarityDegreeType = 581
        ''' <summary>انواع مليت </summary>
        NationalityType = 582
        ''' <summary>انواع دانشگاه ها </summary>
        UnivercityType = 583
        ''' <summary>دانشگاه</summary>
        Univercity = 584
        ''' <summary>گرايش رشته هاي تحصيلي</summary>
        StudyBranchTrend = 585
        ''' <summary>انواع زبان خارجه </summary>
        ForeignLanguageType = 586
        ''' <summary>نظام هاي پرداختني حقوق و دستمزد</summary>
        SalaryPaymentWorkBook = 587
        ''' <summary>مشخصات کارگاه</summary>
        WorkPlaceInfo = 588
        ''' <summary>انواع وضعيت نظام وظيفه</summary>
        MiliarityStatusType = 590
        ''' <summary>انواع پارامترهاي متغير احکام</summary>
        ParameterPrescription = 591
        ''' <summary>انواع وام</summary>
        LoanType = 592
        ''' <summary>انواع گروه هاي کاري</summary>
        WorkGroupType = 593
        ''' <summary>انواع مراکز هزينه حقوق و دستمزد</summary>
        CostCenterSalary = 594
        ''' <summary>عطف رديف سند</summary>
        VoucherItemsRefrence = 595
        ''' <summary>صفات جداول فرعي</summary>
        AccountTableAttribute = 596
        ''' <summary>محلهاي استقرار اموال</summary>
        PossessionLocations = 597
        ''' <summary>فيش حقوقي</summary>
        SalaryّFishName = 598
        ''' <summary>علت تشويق</summary>
        EncouragementReason = 599
        ''' <summary>علت تنبيه</summary>
        GruelingReason = 600
        ''' <summary>علت ترک کار</summary>
        EndWorkReason = 601
        ''' <summary>علت کسورات عمومي حقوق</summary>
        ReduceIncSalaryReason = 602
        ''' <summary>دلايل تغييرات مبلغ اموال</summary>
        PossessionChangePriceReason = 603
        ''' <summary>Selectي</summary>
        Selective = 604
        ''' <summary>تشريحي</summary>
        Anatomical = 605
        ''' <summary>يکتا-کشويي</summary>
        Unique_Combo = 606
        ''' <summary>چندگانه-چک ليست</summary>
        Multiple_Checklist = 607
        ''' <summary>نظرسنجي</summary>
        Survey = 608
        ''' <summary>شکايت</summary>
        Complaint = 609
        ''' <summary>چک ليست</summary>
        CheckList = 610
        ''' <summary>ميهمان غيرمقيم</summary>
        Guest_NoneResiding = 611
        ''' <summary>پرسنل</summary>
        People = 612
        ''' <summary>متفرقه</summary>
        Other = 613
        ''' <summary>يکتا-دکمه راديويي</summary>
        Unique_Radio = 614
        ''' <summary>ميهمان مقيم</summary>
        Guest_Residing = 615
        ''' <summary>آژانس ها</summary>
        Contractors = 616
        ''' <summary>عددي</summary>
        Numeric = 620
        ''' <summary>متن-تک خطي</summary>
        Text_OnlyLine = 621
        ''' <summary>متن-چند خطي</summary>
        Text_MultiLine = 622
        ''' <summary>انواع عيوب</summary>
        DeviceFaultTypes = 623
        ''' <summary>انواع مشخصه هاي تجهيز</summary>
        DevicePropertyTypes = 624
        ''' <summary>انواع عمليات نگهداري تجهيز</summary>
        DeviceOperationTypes = 625
        ''' <summary>انواع مشخصه هاي اموال</summary>
        PossessionPropertyTypes = 626
        ''' <summary>فاصله رزرو به روز اقامت</summary>
        LeadTime = 629
        ''' <summary>رقباي هتل</summary>
        HotelCompetitors = 630
        ''' <summary>زمان اقامت</summary>
        ResidentTime = 631
        ''' <summary>درصد اشغالي</summary>
        Occupancy = 632
        ''' <summary>انواع سگمنت بازار</summary>
        Segment = 633
        ''' <summary>انواع پروموشن</summary>
        Promotion = 634
        ''' <summary>بلوک</summary>
        Block = 636
    End Enum
    '==================================
    ''' <summary>انواع مردم</summary>

    Public Enum FormActionType
        add = 1
        SingleSelection = 2
        View = 3
    End Enum
    Public Enum [Alias]
        a = 1
    End Enum
End Class
