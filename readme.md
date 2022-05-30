# yolov5-annotation-viewer

yolov5 라벨 시각화

![image](https://user-images.githubusercontent.com/34199905/170930845-37b16fd4-db2d-464c-b4bb-71996caddbf2.png)


## Support folder structure

```
└─*any location*
    ├─images
    │   └─*name*.jpg -> source file
    └─labels
        └─*name*.txt -> source file
        
└─*any location*
    *name*.yaml -> header file
```

label file format : \*name\*.txt

![image](https://sguys99.github.io/assets/images/2021-12-21-ds1/ds01.04.jpg)

header file format

```yaml
train: ../train/images
val: ../valid/images

nc: 2
names: ['mask', 'no-mask'] -> required field
```

