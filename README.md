# Szyfrowany Czat z Middlemanem

## 📌 Opis projektu
Aplikacja jest webowym czatem w czasie rzeczywistym z wbudowanym szyfrowaniem oraz możliwością odszyfrowywania wiadomości przez middlemana (serwer lub dodatkową aplikację). 
Użytkownicy mogą komunikować się w bezpieczny sposób, przesyłając zaszyfrowane wiadomości, które mogą zostać odszyfrowane tylko wtedy, gdy odbiorca posiada odpowiedni klucz lub metodę deszyfrującą.

## 🎯 Cele projektu
- Zapewnienie bezpiecznej komunikacji w czasie rzeczywistym.
- Implementacja różnych metod szyfrowania wiadomości.
- Możliwość przechowywania wiadomości na serwerze (middleman) i ich odszyfrowywania.
- Historia rozmów z możliwością przełączania między wersją zaszyfrowaną a odszyfrowaną.

## 🚀 Czym wyróżnia się nasza aplikacja?
- Możliwość odszyfrowywania wiadomości przez middlemana.
- Opcja przełączania między wersją zaszyfrowaną a odszyfrowaną w interfejsie użytkownika.
- Eksperymentalne podejście do testowania różnych metod szyfrowania w czasie rzeczywistym.

## 🏗 Architektura aplikacji

### 📌 Frontend
- **Framework**: Blazor C# *(do potwierdzenia)*
- **UI**: Tailwind CSS
- **Komunikacja**: WebSockets (Socket.io)
- **Funkcjonalności**:
  - Czat w czasie rzeczywistym
  - Szyfrowanie i odszyfrowywanie wiadomości
  - Historia wiadomości z możliwością podglądu wersji zaszyfrowanej i odszyfrowanej

### 📌 Backend
- **Framework**: FastAPI (Python) *(preferowany zamiast Javy)*
- **Komunikacja**: WebSockets do obsługi czatu w czasie rzeczywistym
- **Moduły**:
  - Obsługa szyfrowania i deszyfrowania:
    - **AES (Advanced Encryption Standard)** – Symetryczne szyfrowanie blokowe
    - **ROT13** – Proste szyfrowanie przesunięciowe (klucz: 13)
    - **Base64** – Kodowanie danych na znaki ASCII (nie jest szyfrowaniem)
  - Przechowywanie i zarządzanie wiadomościami
  - Autoryzacja użytkowników

### 📌 Baza danych
- **Technologia**: PostgreSQL + Redis *(opcjonalnie do cache'owania)*
- **Struktura danych**:
  - `Users`: ID, login, hash hasła, klucz szyfrujący
  - `Messages`: ID, nadawca, odbiorca, treść zaszyfrowana, metoda szyfrowania, znacznik czasu

## 📌 Implementacja
### 🧠 Programowanie funkcyjne: `reduce()`
Funkcja `reduce()` pozwala na agregację i analizę danych związanych z wiadomościami, co umożliwia:
- Obliczanie liczby wiadomości dla każdego użytkownika.
- Tworzenie statystyk na podstawie metod szyfrowania.
- Grupowanie wiadomości według użytkowników w jednym przebiegu po danych, poprawiając wydajność.

**Dlaczego `reduce()`?**
- **Optymalizacja**: Przetwarza dane w jednym przebiegu, redukując zużycie pamięci.
- **Czytelność**: Kod jest bardziej deklaratywny i zwięzły niż tradycyjne pętle.
- **Skalowalność**: Możliwość łatwego rozszerzania o dodatkowe warunki (np. filtrowanie po metodzie szyfrowania).

## 🔜 Kolejne kroki
- Implementacja prototypu.
- Testowanie różnych metod szyfrowania w rzeczywistych warunkach.
- Optymalizacja operacji na wiadomościach.

---
📌 **Autor:** *Oliwia Lukasik i Oleksandra Nesterchuk*
