Feature: LoginPage
	It is testing Trendyol Login Page

Scenario: LoginWithWrongEmailAndPassword
	* 'https://www.trendyol.com/giris' sayfasi acilir
	* E-Posta alanina 'deneme' girilir
	* Şifre alanina 'deneme' girilir
	* Giris yap butonuna tiklanir
	* 'Lütfen geçerli bir e-posta adresi giriniz.' mesaji gorulerek test basarili sonuclanir