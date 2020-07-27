# Rpt Decoder
This application decodes the `.rpt` file that is produced from X-Plane's automatic crash reporter. The `.rpt` file consist of base64 encoded strings; one for the crash dump `.dmp` and one for the X-Plane `log.txt` (and some other information as well). This tool decodes the strings and saves the files in their original format for easy viewing.

## Usage
`RptDecoder.exe "C:\Path\To\Rpt\File"`

Alternatively, you can drag and drop the `.rpt` file onto the `RptDecoder.exe`.

The decoded files will be saved in the same folder where `RptDecoder.exe` lives.
