Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Resources
Imports System.Windows

' Ogólne informacje o zestawie są kontrolowane poprzez następujący 
' zestaw atrybutów. Zmień wartości tych atrybutów, aby zmodyfikować informacje
' powiązane z zestawem.

' Sprawdź wartości atrybutów zestawu

<Assembly: AssemblyTitle("Multi_threading_ProgressBar")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("Multi_threading_ProgressBar")>
<Assembly: AssemblyCopyright("Copyright ©  2019")>
<Assembly: AssemblyTrademark("")>
<Assembly: ComVisible(false)>

'Aby rozpocząć kompilację aplikacji możliwych do zlokalizowania, ustaw
'<UICulture>Kultura_używana_podczas_kodowania</UICulture> w pliku vbproj
'w grupie <PropertyGroup>. Jeśli na przykład jest używany język angielski (USA)
'w plikach źródłowych ustaw dla elementu <UICulture> wartość „en-US”. Następnie usuń komentarz dla
'poniższego atrybutu NeutralResourceLanguage. Zaktualizuj wartość „en-US” w wierszu
'poniżej tak, aby dopasować do ustawienia UICulture w pliku projektu.

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)>


'Atrybut ThemeInfo wskazuje, gdzie można znaleźć słowniki zasobów ogólnych i specyficznych dla motywów.
'pierwszy parametr: gdzie znajdują się słowniki zasobów specyficznych dla motywów
'(używane, jeśli nie można odnaleźć zasobu na stronie,
' lub słowniki zasobów aplikacji)

'drugi parametr: gdzie znajduje się słownik zasobów ogólnych
'(używane, jeśli nie można odnaleźć zasobu na stronie,
'aplikacji i słowników zasobów specyficznych dla motywów)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'Następujący identyfikator GUID jest identyfikatorem biblioteki typów w przypadku udostępnienia tego projektu w modelu COM
<Assembly: Guid("6a80a388-46b4-4859-af42-87625f53d7b4")>

' Informacje o wersji zestawu zawierają następujące cztery wartości:
'
'      Wersja główna
'      Wersja pomocnicza
'      Numer kompilacji
'      Rewizja
'
' Możesz określić wszystkie wartości lub użyć domyślnych numerów kompilacji i poprawki
' przy użyciu symbolu „*”, tak jak pokazano poniżej:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
