Feature: LoginPage
	It is testing Trendyol Login Page

Scenario: LoginWithWrongEmailAndPassword
	* 'https://www.trendyol.com/giris' sayfasi acilir
	* E-Posta alanina 'deneme' girilir
	* Şifre alanina 'deneme' girilir
	* Giris yap butonuna tiklanir
	* 'Lütfen geçerli bir e-posta adresi giriniz.' mesaji gorulerek test basarili sonuclanir

Scenario: LoginWithTrueEmailAndPassword
	* 'https://www.trendyol.com/giris' sayfasi acilir
	* E-Posta alanina 'testselenium95@gmail.com' girilir
	* Şifre alanina 'KendiMailVeSifreniziGiriniz :))' girilir
	* Giris yap butonuna tiklanir
	* Hesabim geldigi gorulur ve test basarili sonuclanir

	Scenario: LoginWithTrueEmailAndWrongPassword
	* 'https://www.trendyol.com/giris' sayfasi acilir
	* E-Posta alanina 'testselenium95@gmail.com' girilir
	* Şifre alanina 'deneme' girilir
	* Giris yap butonuna tiklanir
	* 'E-posta adresiniz ve/veya şifreniz hatalı.' mesaji gorulerek test basarili sonuclanir