#include <QCoreApplication>
#include <QSerialPort>
#include <QDebug>
#include <QThread>

#include <cstdlib>
#include <ctime>

int main(int argc, char *argv[]) {
    QCoreApplication a(argc, argv);
    QSerialPort serial;
    QSerialPort::SerialPortError err;

    const char* portName = NULL;
    if (argc >= 2) {
        portName = argv[1];
    } else {
        portName = 
#if (0)
        "/dev/pts/18"; // socat -d -d pty,raw,echo=0 pty,raw,echo=0
#else
        "\\\\.\\COM9";
#endif
    }
    serial.setPortName(portName);
    if (!serial.open(QIODevice::ReadWrite)) {
        qWarning("ERR: %s %s", portName, serial.errorString().toUtf8().data());
        return EXIT_FAILURE;
    }
    serial.setBaudRate(QSerialPort::Baud115200);
    serial.setDataBits(QSerialPort::Data8);
    serial.setParity(QSerialPort::NoParity);
    serial.setStopBits(QSerialPort::OneStop);
    serial.setFlowControl(QSerialPort::NoFlowControl);

    srand((unsigned)time(NULL));

    QByteArray data;
	
	QStringList sample = QStringList() 
	
	
#if (1)

	<< "\rCARE,00,D,P,1103,856         ,001,03.09.18,03:02,  6.20,mmol/l,0\r"
	<< "\rCARE,00,D,P,1104,855         ,002,03.09.18,03:01,  6.22,mmol/l,0\r"
	<< "\rCARE,00,D,P,1105,854         ,003,03.09.18,03:00,  6.24,mmol/l,0\r"
	<< "\rCARE,00,D,P,1106,853         ,004,03.09.18,02:59,  6.21,mmol/l,0\r"
	<< "\rCARE,00,D,P,1107,852         ,005,03.09.18,02:58,  6.23,mmol/l,0\r"
	<< "\rCARE,00,D,P,1108,851         ,006,03.09.18,02:57,  6.25,mmol/l,0\r";
	QByteArray lf("\r");

#else`
<<
"<!--:Begin:Chksum:1:-->\r\n"
"<!--:Begin:Msg:1:0:-->\r\n"
"<sample>\r\n"
"<ver>1.1</ver>\r\n"
"<instrinfo>\r\n"
"<p><n>PRDI</n><v>BM800</v></p>\r\n"
"<p><n>FIWV</n><v>2.8.1</v></p>\r\n"
"<p><n>SNO</n><v>21754</v></p>\r\n"
"<p><n>BRND</n><v>S</v></p>\r\n"
"<p><n>IAPL</n><v>H</v></p>\r\n"
"<p><n>IID</n></p>\r\n"
"<p><n>LMOF</n><v>1</v></p>\r\n"
"</instrinfo>\r\n"
"<smpinfo>\r\n"
"<p><n>ID</n><v>0178171</v></p>\r\n"
"<p><n>SEQ</n><v>2639</v></p>\r\n"
"<p><n>DATE</n><v>2018-08-14T13:01:04</v></p>\r\n"
"<p><n>OPID</n></p>\r\n"
"<p><n>APNU</n><v>1</v></p>\r\n"
"<p><n>APNA</n><v>BLOOD</v></p>\r\n"
"<p><n>ASPM</n><v>OT</v></p>\r\n"
"<p><n>ASPS</n><v>1</v></p>\r\n"
"<p><n>SORC</n><v>0</v></p>\r\n"
"<p><n>BLMD</n><v>0</v></p>\r\n"
"<p><n>BLNK</n><v>0</v></p>\r\n"
"<p><n>STYP</n><v>0</v></p>\r\n"
"<p><n>RGED</n></p>\r\n"
"<p><n>RGEL</n></p>\r\n"
"<p><n>RGEC</n></p>\r\n"
"<p><n>RDLI</n><v>1711-843</v></p>\r\n"
"<p><n>RDPN</n><v>1157</v></p>\r\n"
"<p><n>RDED</n><v>2020-11-13</v></p>\r\n"
"<p><n>RLLI</n><v>1712-857</v></p>\r\n"
"<p><n>RLPN</n><v>204</v></p>\r\n"
"<p><n>RLED</n><v>2020-12-03</v></p>\r\n"
"<p><n>RCLI</n></p>\r\n"
"<p><n>RCPN</n></p>\r\n"
"<p><n>RCED</n></p>\r\n"
"<p><n>RELI</n></p>\r\n"
"<p><n>REPN</n></p>\r\n"
"<p><n>REED</n></p>\r\n"
"<p><n>RPD</n><v>30</v></p>\r\n"
"<p><n>RPDS</n><v>1</v></p>\r\n"
"<p><n>RPDL</n><v>15</v></p>\r\n"
"<p><n>RPDH</n><v>30</v></p>\r\n"
"<p><n>RPDF</n><v>27</v></p>\r\n"
"<p><n>MBTE</n><v>28.9</v></p>\r\n"
"<p><n>MCVO</n><v>+0.0</v></p>\r\n"
"<p><n>WDDM</n><v>0</v></p>\r\n"
"<p><n>WDDP</n><v>45</v></p>\r\n"
"<p><n>WDMS</n><v>2</v></p>\r\n"
"<p><n>WDMA</n><v>2</v></p>\r\n"
"<p><n>WDFB</n><v>0</v></p>\r\n"
"<p><n>WDLL</n></p>\r\n"
"<p><n>WDLH</n></p>\r\n"
"<p><n>WDCL</n></p>\r\n"
"<p><n>WDCH</n></p>\r\n"
"<p><n>WLGL</n></p>\r\n"
"<p><n>WLGH</n></p>\r\n"
"<p><n>WDIL</n><v>140</v></p>\r\n"
"<p><n>WDIH</n><v>180</v></p>\r\n"
"<p><n>WDOM</n><v>0</v></p>\r\n"
"<p><n>WDWD</n><v>2</v></p>\r\n"
"<p><n>XLT</n></p>\r\n"
"<p><n>EOMD</n></p>\r\n"
"<p><n>EODL</n></p>\r\n"
"<p><n>EODH</n></p>\r\n"
"<p><n>EOAC</n></p>\r\n"
"<p><n>EOWC</n></p>\r\n"
"<p><n>XEIT</n></p>\r\n"
"<p><n>EASS</n></p>\r\n"
"<p><n>CAPL</n></p>\r\n"
"<p><n>CLVL</n></p>\r\n"
"<p><n>CEXP</n></p>\r\n"
"<p><n>CEXT</n></p>\r\n"
"<p><n>EXCL</n></p>\r\n"
"<p><n>ASWP</n></p>\r\n"
"<p><n>ID2</n></p>\r\n"
"</smpinfo>\r\n"
"<smpresults>\r\n"
"<p><n>RBC</n><v>3.96</v><l>3.50</l><h>5.50</h></p>\r\n"
"<p><n>MCV</n><v>85.4</v><l>75.0</l><h>100.0</h></p>\r\n"
"<p><n>HCT</n><v>33.9</v><l>35.0</l><h>55.0</h></p>\r\n"
"<p><n>MCH</n><v>31.7</v><l>25.0</l><h>35.0</h></p>\r\n"
"<p><n>MCHC</n><v>37.1</v><l>31.0</l><h>38.0</h></p>\r\n"
"<p><n>RDWR</n><v>13.6</v><l>11.0</l><h>16.0</h></p>\r\n"
"<p><n>RDWA</n><v>56.4</v><l>30.0</l><h>150.0</h></p>\r\n"
"<p><n>PLT</n><v>247</v><l>100</l><h>400</h></p>\r\n"
"<p><n>MPV</n><v>7.8</v><l>8.0</l><h>11.0</h></p>\r\n"
"<p><n>PCT</n><v>0.19</v><l>0.01</l><h>9.99</h></p>\r\n"
"<p><n>PDW</n><v>11.1</v><l>0.1</l><h>99.9</h></p>\r\n"
"<p><n>LPCR</n><v>13.5</v><l>0.1</l><h>99.9</h></p>\r\n"
"<p><n>HGB</n><v>12.5</v><l>11.5</l><h>16.5</h></p>\r\n"
"<p><n>WBC</n><v>6.2</v><l>3.5</l><h>10.0</h></p>\r\n"
"<p><n>LA</n><v>2.0</v><l>0.5</l><h>5.0</h></p>\r\n"
"<p><n>MA</n><v>0.4</v><l>0.1</l><h>1.5</h></p>\r\n"
"<p><n>GA</n><v>3.8</v><l>1.2</l><h>8.0</h></p>\r\n"
"<p><n>LR</n><v>32.4</v><l>15.0</l><h>50.0</h></p>\r\n"
"<p><n>MR</n><v>6.0</v><l>2.0</l><h>15.0</h></p>\r\n"
"<p><n>GR</n><v>61.6</v><l>35.0</l><h>80.0</h></p>\r\n"
"</smpresults>\r\n"
"<tparams>\r\n"
"<p><n>RCT</n><v>14844</v></p>\r\n"
"<p><n>WCT</n><v>11391</v></p>\r\n"
"<p><n>aspt</n><v>1381</v></p>\r\n"
"</tparams>\r\n"
"</sample>\r\n"
"<!--:End:Msg:1:0:-->\r\n"
"<!--:End:Chksum:1:241:55:-->\r\n";
QByteArray lf("\r\n");

#endif

    for (unsigned cnt=0;;) {
        err = serial.error();
        if (err != QSerialPort::NoError) {
            qWarning("ERR: %s", serial.errorString().toUtf8().data());
            break;
        }
		//qDebug() << "write";
		
		if (rand() % 100 > 80)
			serial.write(sample[ rand() % sample.size() ].toLatin1());
		else
			serial.write(lf);
		
        if (++cnt > 3) {
            cnt = 0;
            serial.flush();
            QThread::msleep(500);
        } else {
            QThread::msleep(300);
        }
    }
    serial.close();
    return EXIT_SUCCESS;
}

