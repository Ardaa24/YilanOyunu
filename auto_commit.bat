@echo off
cd /d "D:\testarea\YilanOyunu\YilanOyunu"
git add .
git commit -m "Auto commit - %date% %time%"
git push origin main
echo ✅ Kodlar GitHub’a yüklendi!
pause
