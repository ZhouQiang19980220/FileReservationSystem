/*ɾ�����б�*/
DROP TABLE T_EVENT;
DROP TABLE T_APPLICATION;
DROP TABLE T_USER;
DROP TABLE T_DOCUMENT;
DROP SEQUENCE SEQ_EVENT;

/*�½����б�*/
CREATE TABLE T_DOCUMENT (                                      -- ������
    DOCUMENT_CODE         varchar2(11)                 NOT NULL,     --������
    STU_NAME         varchar2(8)                  NOT NULL,     --����
    MAJORNO      varchar2(4)                  NOT NULL,     --����Ժϵ
    POSITION     varchar2(6)                  NOT NULL,     --�ڼ�λ��
    STATUS       number(1)   default  0       NOT NULL,     --״̬
    CONSTRAINT DCPK PRIMARY KEY (DOCUMENT_CODE)
);

CREATE TABLE T_USER (                                       -- �û�����
    USERID       number(8)                              NOT NULL,     --�û�ID
    PW           varchar2(20)                           NOT NULL,     --����
    IDCODE       varchar2(11)                           NOT NULL,     --������
    usertype     number(1)     default  0               NOT NULL,     --�û����ͣ���ͨ�û���0�� Ժϵ����Ա��1�� ��������Ա
    CONSTRAINT  USERPK  PRIMARY KEY (USERID),
    /*�û�����������Դ�ڵ���������*/
    CONSTRAINT  USERFK1  FOREIGN KEY (IDCODE) REFERENCES T_DOCUMENT(DOCUMENT_CODE)
);

CREATE TABLE T_APPLICATION (                                  -- ԤԼ��
    APPID        varchar2(12)                      NOT NULL,     -- ԤԼ��
    TEECODE      varchar2(11)                      NOT NULL,     -- �����˵�����
    OBJCODE      varchar2(11)                      NOT NULL,     -- �����ĵ�����
    AUTHCODE     varchar2(11)                      NOT NULL,     -- ��Ȩ�˵�����
    APPSTATUS    varchar2(10)                      NOT NULL,     -- ����״̬ �������Ѿ�ͬ����Ȩ���˻أ������Ѿ�����������������
    TIME         date                              NOT NULL,     -- ��������
    CONSTRAINT  APPPK  PRIMARY KEY (APPID),
     /*�����˵���������Դ�ڵ���������*/
    CONSTRAINT  APPFK1  FOREIGN KEY (TEECODE) REFERENCES T_DOCUMENT(DOCUMENT_CODE),
     /*�����ĵ���������Դ�ڵ���������*/
    CONSTRAINT  APPFK2  FOREIGN KEY (OBJCODE) REFERENCES T_DOCUMENT(DOCUMENT_CODE), 
     /*�û�����������Դ�ڵ���������*/
    CONSTRAINT  APPFK3  FOREIGN KEY (AUTHCODE) REFERENCES T_DOCUMENT(DOCUMENT_CODE)
);

CREATE TABLE T_EVENT  (                                      -- �¼���
    EVENTNO      varchar2(16)                 NOT NULL,     --�¼���
    EVENT_TYPE         number(1)                    NOT NULL,     --�¼�����
    OBJCODE      varchar2(11)                 NOT NULL,     --�������
    APPID        varchar2(12)                 NULL,     --ԤԼ��
    EVTAID       number(8)                    NOT NULL,     --�������Ա
    EDATE        date                         NOT NULL,     --����
    CONSTRAINT EVTPK PRIMARY KEY (EVENTNO),
    /* ���OBJCODE */
    CONSTRAINT EVTFK1 FOREIGN KEY (OBJCODE) REFERENCES T_DOCUMENT(DOCUMENT_CODE),
    /* ���APPID */
    CONSTRAINT EVTFK2 FOREIGN KEY (APPID) REFERENCES T_APPLICATION(APPID),
    /* ���EVTAID */
    CONSTRAINT EVTFK3 FOREIGN KEY (EVTAID) REFERENCES T_USER(USERID)
);

--���У������¼��������
CREATE SEQUENCE seq_event
     INCREMENT BY 1   -- ÿ�μӼ���  
     START WITH 1     -- ��1��ʼ����  
     NOMAXVALUE       -- ���������ֵ  
     NOCYCLE          -- һֱ�ۼӣ���ѭ��  
     CACHE 10; 


/*��������*/
/*������*/
/*��ͨ�û�*/
INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
VALUES ('2017010001', '��ǿ', 'DA', 'A2K4', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2017010002', '��ľ��','DA', 'A2K5', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2017010003', '���е�', 'DA','A2K16', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2017010004', '����', 'DA','A3K1', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2017020001', '���͵�', 'CS','A3K5', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2017020002', '����', 'CS','A3K191', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2017020003', 'ŷ��٤','CS', 'A3K13', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2017020004', '�°���','CS', 'A3K8', 0);

/*Ժϵ����Ա*/
INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2007030001', '������','DA', 'A3K4', 0);

INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2007030002', '�����','CS', 'A3K9', 0);

/*��������Ա*/
INSERT INTO T_DOCUMENT(DOCUMENT_CODE, STU_NAME, MAJORNO, POSITION, STATUS)
values ('2007040001', '����Ա','DAG', 'A3K2', 0);

select * from t_document;

/*�û�����*/
/*��ͨ�û�*/
INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200001', 'S20200001', '2017010001', 0);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200002', 'S20200002', '2017010002', 0);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200003', 'S20200003', '2017010003', 0);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200004', 'S20200004', '2017010004', 0);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200005', 'S20200005', '2017020001', 0);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200006', 'S20200006', '2017020002', 0);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200007', 'S20200007', '2017020003', 0);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200008', 'S20200008', '2017020004', 0);

/*Ժϵ����Ա*/
INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200009', 'S20200009', '2007030001', 1);

INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200010', 'S20200010', '2007030002', 1);

/*��������Ա*/
INSERT INTO T_USER(USERID, PW, IDCODE, usertype)
VALUES ('20200011', 'S20200011', '2007040001', 2);

select * from t_user;


/*ԤԼ��*/
INSERT INTO T_APPLICATION(APPID, TEECODE, OBJCODE, AUTHCODE, APPSTATUS, TIME)
VALUES ('202012200001', '2017010001', '2017010002', '2007030001', '������', TO_DATE('20201220', 'YYYYMMDD'));

INSERT INTO T_APPLICATION(APPID, TEECODE, OBJCODE, AUTHCODE, APPSTATUS, TIME)
VALUES ('202012200002', '2017010001', '2017010003', '2007030001', '������', TO_DATE('20201220', 'YYYYMMDD'));

INSERT INTO T_APPLICATION(APPID, TEECODE, OBJCODE, AUTHCODE, APPSTATUS, TIME)
VALUES ('202012200003', '2017010001', '2017010004', '2007030001', '������', TO_DATE('20201220', 'YYYYMMDD'));

SELECT * FROM T_APPLICATION;

/*�¼���*/
/*
INSERT INTO T_EVENT(EVENTNO, EVENT_TYPE, OBJCODE, APPID, EVTAID, EDATE)
VALUES(SEQ_EVENT.NEXTVAL, 0, '2007030001', null, '20200011', TO_DATE('20201231', 'YYYYMMDD'));
*/
--INSERT INTO T_EVENT(EVENTNO, EVENT_TYPE, OBJCODE, APPID, EVTAID, EDATE)  VALUES(SEQ_EVENT.NEXTVAL,    0,        '2017010003',   '', '20200011',  TO_DATE('20201231', 'YYYYMMDD'));
commit;

select * from t_event;


