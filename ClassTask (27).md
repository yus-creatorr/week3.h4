### Polymorphism
You are developing an application for analyzing Instagram activity.
You have a base class called `User` and two derived classes: `RegularUser` and `Influencer`.
Both classes have a method called `ViewActivity`, but each class uses this method differently.
Regular users can view only their own activity, while influencers can view the activity of their followers.
##
Вы создаете приложение для анализа активности на Instagram.     
У вас есть базовый класс `User` и два класса-наследника:    
`RegularUser` и `Influencer`.      
Оба класса имеют метод `ViewActivity`, но каждый класс использует этот метод по-своему.       
Обычные пользователи могут просматривать только свою собственную активность, 
а инфлюэнсеры могут просматривать активность своих подписчиков.
##
Шумо барномаеро барои таҳлили фаъолият дар Instagram эҷод мекунед. Шумо класси асосии `User` ва ду класси инҳеритшуда доред: `RegularUser` ва `Influencer`. Ҳарду класс усули `ViewActivity` доранд, аммо ҳар як класс ин усулро ба таври гуногун истифода мебарад. Корбарони муқаррарӣ метавонанд танҳо фаъолияти худро бубинанд, дар ҳоле ки таъсиррасон метавонанд фаъолияти пайравони худро бубинанд.

---

### Virtual Methods
You are creating an application for uploading and processing photos on Instagram.
You have a base class called `Photo` and a derived class called `ProcessedPhoto`.
The `Photo` class has a virtual method called `Display` that outputs the photo on the screen.
The `ProcessedPhoto` class overrides this method and adds additional functionality such as filters or effects.
##
Вы создаете приложение для загрузки и обработки фотографий в Instagram.    
У вас есть базовый класс `Photo` и класс-наследник `ProcessedPhoto`.       
У класса `Photo` есть виртуальный метод `Display`, который выводит фотографию на экран. 
Класс `ProcessedPhoto` переопределяет этот метод, добавляя к нему дополнительный функционал, например, фильтры или эффекты.
##
Шумо барномаеро барои боргузорӣ ва коркарди аксҳо дар Instagram месозед.
Шумо як класси асосӣ `Photo` ва зеркласси `ProcessedPhoto` доред.
Класси `Photo` дорои усули виртуалии `Display` мебошад, ки аксро дар экран намоиш медиҳад.
Класси `ProcessedPhoto` ин усулро оверайд мекунад ва ба он функсияҳои иловагӣ, ба монанди филтрҳо ё эффектҳо илова мекунад.

---

### Abstract Classes
You are developing an account management system for Instagram.
You have an abstract class called `Account` that contains common methods and properties for all accounts.
The class is inherited by `UserAccount` and `BusinessAccount` classes, which add specific functionality for each type of account.
##
Вы разрабатываете систему управления аккаунтами в Instagram.      
У вас есть абстрактный класс `Account`, который содержит общие методы и свойства для всех аккаунтов.    
От этого класса наследуются классы `UserAccount` и `BusinessAccount`,   
которые дополняют его функционалом специфичным для каждого типа аккаунта.  
##
Шумо системаи идоракунии аккаунтҳоро барои Instagram таҳия карда истодаед.
Шумо класси абстрактии `Account` доред, ки дорои усулҳо ва хосиятҳои умумӣ барои ҳама аккаунтҳо мебошад.
Классҳои `UserAccount` ва `BusinessAccount` аз ин класс ба мерос гирифта шудаанд,
ки онро бо функсияҳои хоси ҳар як намуди ҳисоб пурра мекунанд.

---

### Abstract Methods
You are creating a content publishing system for Instagram.
You have an abstract class called `Publication` with an abstract method called `Publish`.
Derived classes like `Photo` and `Video` need to implement this method differently based on the type of content.
##
Вы создаете систему публикации контента в Instagram.       
У вас есть абстрактный класс `Publication`, у которого есть абстрактный метод `Publish`.    
Классы-наследники, например `Photo` и `Video`, должны реализовать этот метод по-своему, в зависимости от типа контента. 
##
Шумо системаи интишори мундариҷаро дар Instagram эҷод мекунед.
Шумо класси абстрактии `Publication` доред, ки усули абстрактии `Publish` дорад.
Зерклассҳои ҳосилшуда, ба монанди `Photo` ва `Video`, бояд ин усулро вобаста ба намуди мундариҷа ба таври гуногун татбиқ кунанд.
