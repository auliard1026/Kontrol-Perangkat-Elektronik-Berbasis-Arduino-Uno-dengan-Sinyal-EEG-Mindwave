<h1 class="code-line" data-line-start=0 data-line-end=1 ><a id="Kontrol_Perangkat_Elektronik_Berbasis_Arduino_Uno_dengan_Sinyal_EEG_Mindwave_0"></a>Kontrol Perangkat Elektronik Berbasis Arduino Uno dengan Sinyal EEG Mindwave</h1>
<h2 class="code-line" data-line-start=2 data-line-end=3 ><a id="Deskripsi_Proyek_2"></a>Deskripsi Proyek</h2>
<p class="has-line-data" data-line-start="3" data-line-end="4">Proyek ini bertujuan untuk mengontrol perangkat elektronik menggunakan sinyal EEG dari sensor Mindwave yang dikirimkan ke Arduino Uno. Sistem ini memungkinkan sensor EEG untuk menangkap aktivitas gelombang otak, lalu menerjemahkannya menjadi perintah yang dieksekusi oleh perangkat elektronik. Dalam contoh ini, sinyal EEG digunakan untuk menyalakan dan mematikan lampu.</p>
<h2 class="code-line" data-line-start=4 data-line-end=5 ><a id="Perangkat_Keras__Perangkat_Lunak_4"></a>Perangkat Keras &amp; Perangkat Lunak</h2>
<p class="has-line-data" data-line-start="5" data-line-end="6">Berikut adalah komponen dan alat yang digunakan dalam proyek ini:</p>
<ol>
<li class="has-line-data" data-line-start="6" data-line-end="7">Arduino Uno R3</li>
<li class="has-line-data" data-line-start="7" data-line-end="8">Mindwave EEG Sensor</li>
<li class="has-line-data" data-line-start="8" data-line-end="9">Lampu LED</li>
<li class="has-line-data" data-line-start="9" data-line-end="10">Relay</li>
<li class="has-line-data" data-line-start="10" data-line-end="11">Kabel Serial</li>
<li class="has-line-data" data-line-start="11" data-line-end="12">Jumper</li>
<li class="has-line-data" data-line-start="12" data-line-end="13">Visual Studio (untuk membuat program komunikasi)</li>
<li class="has-line-data" data-line-start="13" data-line-end="15">Arduino IDE (untuk mengunggah kode ke Arduino)</li>
</ol>
<h2 class="code-line" data-line-start=15 data-line-end=16 ><a id="Instalasi_Driver_15"></a>Instalasi Driver</h2>
<p class="has-line-data" data-line-start="16" data-line-end="17">Sebelum memulai perancangan sistem, pastikan untuk menginstal driver yang diperlukan:</p>
<ul>
<li class="has-line-data" data-line-start="18" data-line-end="19">Arduino Driver:</li>
<li class="has-line-data" data-line-start="19" data-line-end="21">Mindwave EEG Sensor Driver:</li>
</ul>
<h2 class="code-line" data-line-start=21 data-line-end=22 ><a id="Langkahlangkah_21"></a>Langkah-langkah</h2>
<ol>
<li class="has-line-data" data-line-start="22" data-line-end="23">Unduh dan Instalasi: Unduh program yang tersedia di repositori ini. Setelah itu, sambungkan Arduino Uno dan adapter Mindwave ke komputer. Pastikan perangkat terdeteksi di Device Manager, dan periksa port serial yang digunakan untuk menyamakan dengan program.</li>
<li class="has-line-data" data-line-start="23" data-line-end="24">Upload Program ke Arduino: Buka file .ino di Arduino IDE, kemudian unggah program ke Arduino Uno.</li>
<li class="has-line-data" data-line-start="24" data-line-end="26">Jalankan Program Mindwave di Visual Studio: Setelah mengunggah program ke Arduino, buka proyek Visual Studio dan jalankan program. Tunggu beberapa saat hingga perangkat terdeteksi dan terhubung.</li>
</ol>
<h2 class="code-line" data-line-start=26 data-line-end=27 ><a id="Struktur_Program_26"></a>Struktur Program</h2>
<ul>
<li class="has-line-data" data-line-start="27" data-line-end="28">Arduino Program: Program ini mengatur komunikasi serial antara Arduino dan Visual Studio, serta mengontrol output berdasarkan sinyal dari sensor EEG.</li>
<li class="has-line-data" data-line-start="28" data-line-end="30">Visual Studio Program: Program ini menerima data dari Mindwave dan meneruskannya ke Arduino untuk mengeksekusi perintah.</li>
</ul>
<h2 class="code-line" data-line-start=30 data-line-end=31 ><a id="Catatan_Penting_30"></a>Catatan Penting!!</h2>
<ul>
<li class="has-line-data" data-line-start="31" data-line-end="32">Pastikan port yang digunakan sudah benar dan perangkat terhubung dengan baik.</li>
<li class="has-line-data" data-line-start="32" data-line-end="34">Jika mengalami masalah dalam deteksi perangkat, coba periksa Device Manager dan pastikan driver telah terinstal dengan benar.</li>
</ul>
<p class="has-line-data" data-line-start="34" data-line-end="35">Baiklah, itu adalah proyek yang dapat saya bagikan kali ini. Jika ada teman-teman yang memiliki pertanyaan atau ingin mendiskusikan lebih lanjut, jangan ragu untuk menghubungi saya melalui link di bawah ini.</p>

<ul>
  <li>Instagram: <a href="https://www.instagram.com/_dhan.i/" target="_blank">_dhan.i</a></li>
  <li>LinkedIn: <a href="https://www.linkedin.com/in/ramadhani-aulia/" target="_blank">Aulia Ramadhani</a></li>
</ul>
