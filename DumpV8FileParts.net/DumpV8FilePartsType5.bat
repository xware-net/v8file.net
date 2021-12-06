for /R %1 %%a in (*.dgn;*.cell;*.dgnlib) do call bin\Debug\net5.0\DumpV8FileParts.net.exe -f "%%a" -o "n:\temp\outdir" -t 5 -l 1
for /R %1 %%a in (*.dgn;*.cell;*.dgnlib) do call bin\Debug\net5.0\DumpV8FileParts.net.exe -f "%%a" -o "n:\temp\outdir" -t 5 -l 3
