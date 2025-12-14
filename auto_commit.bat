@echo off
chcp 65001 >nul
cd /d "D:\testarea\YilanOyunu\YilanOyunu"

:: Git deposu kontrolü
if not exist ".git" (
    echo 🚫 Bu klasör bir Git deposu değil. GitHub bağlantısı oluşturuluyor...
    git init
    set /p repoUrl="Lütfen GitHub repo URL'ni gir (örnek: https://github.com/Ardaa24/YilanOyunu.git): "
    git remote add origin %repoUrl%
    git branch -M main
    echo ✅ Git deposu oluşturuldu.
)

:: Commit ve push işlemleri
git add .
git commit -m "Auto commit - %date% %time%"
git push origin main

echo ✅ Kodlar GitHub'a yüklendi!
pause